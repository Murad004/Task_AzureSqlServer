// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

alert("salam");


$(document).on("change", "#CategorySelect", function () {
    var prod = this;

    $.ajax({
        url: "/Home/ReturnJsonProducts/?categoryId=" + $(prod).val(),
        type: "GET",
        contentType: "application/json; charset=utf-8",
        datatype: JSON,
        success: function (result) {
            var products = "";
            var item = "";
            $(result).each(function () {
                products = products + '<tr class="text - start" > <th scope="row" > '+ this.ProductId +' </th> <td > '+ this.Name +' </td> <td > '+ this.ProductNumber +' </td> <td > ' +this.Color +' </td> <td > <div> <button type="submit" class="btn ms-3 text-white" style = "background-color:darkblue;" > Update </button> <button type = "submit" class="btn ms-2 text-white" style = "background-color:red;" > Remove </button> </div> </td> </tr>'
            });
            var prodList = $("#prodbody");
            prodList.empty();
            prodList.append(products);
        },
        error: function (data) {
            console.log(data)
            return "Error";
        }
    });
});
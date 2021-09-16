$(function () {
    $("#Userinput").keyup(function (e) {
        var searchInput = $("#Userinput").val();

        $.ajax({
            url: "/Games/Search", //in what controller to search
            data: { query: searchInput } // the name from the html (query) and the data we want 

        }).done(function (data) {

            //this work
            $("#tab").html(data); // tbody is the tag we want to fill from the data
            console.log(data);

        });
    });
});


$(function () {
    $("#UserinputAcss").keyup(function (e) {
        var searchInput = $("#UserinputAcss").val();

        $.ajax({
            url: "/Accessories/Search", //in what controller to search
            data: { query: searchInput } // the name from the html (query) and the data we want 

        }).done(function (data) {

            //this work
            $("#tabAcss").html(data); // the tag we want to fill from the data
            console.log(data);

        });
    });
});

$(function () {
    $("#UserToSearch").keyup(function (e) {
        var searchInput = $("#UserToSearch").val();

        $.ajax({
            url: "/Users/Search", //in what controller to search
            data: { query: searchInput } // the name from the html (query) and the data we want (searchInput)

        }).done(function (data) {

            //this work
            $("#userSearch").html(data); // the tag we want to fill from the data
            console.log(data);

        });
    });
});
$(document).ready(function () {

    function espnNews() { 
    $('#container').load('http://google.com');

    $.ajax({
        url: "http://api.espn.com/v1/sports/mma/news/?limit=10&apikey=4pp973uwpnksmkxtjdtupsfh",

        success: function (data) {
            var ul = $('<ul/>');
            $.each(data.headlines, function () {

                var li = $('<li/>').append("<a href=" + this.links.web.href + " target='_blank'>" + this.headline + "<a/>");

                ul.append(li);
            });

            $('#newsfeed').append(ul);
        }
    });
}
    espnNews();
});
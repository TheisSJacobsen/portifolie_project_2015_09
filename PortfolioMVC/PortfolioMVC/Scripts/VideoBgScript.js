var player = $("#bgVideo").get(0);
player.controls = false;
$(player).bind('timeupdate', function () { sessionStorage.setItem("time", player.currentTime) });
$('html').ready(function () {
    var time = sessionStorage.getItem("time");
    if (time != undefined && time != null)
        player.currentTime = parseFloat(time);
})
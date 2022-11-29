
$("#sidebar").click(function(){
    if ($(".sidebar-section").hasClass("width-24"))
    {
        $(".sidebar-section").removeClass("width-24");
        $(".sidebar-section").addClass("width-9");
        $("#sidebar").removeClass("fa-angle-left");
        $("#sidebar").addClass("fa-angle-right");
        $(".content").addClass("mgl-9");
    } else {
        $(".sidebar-section").removeClass("width-9");
        $(".sidebar-section").addClass("width-24");
        $("#sidebar").removeClass("fa-angle-right");
        $("#sidebar").addClass("fa-angle-left");
        $(".content").removeClass("mgl-9");
    }
})
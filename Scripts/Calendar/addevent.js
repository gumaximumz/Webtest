
function Add_event(newevent, currColor, externalevents) {
    var val = newevent.val();
    if (val.length == 0) {
        return;
    }
    var event = $("<div />");
    event.css({ "background-color": currColor, "border-color": currColor, "color": "#fff" }).addClass("external-event");
    event.html(val);
    externalevents.prepend(event);
    ini_events(event);
    newevent.val("");
}
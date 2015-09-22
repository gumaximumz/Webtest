
SelectCalendarJob = function () {
    this.getUrl = '';
};
SelectCalendarJob.prototype.init = function () {
    $.get(this.getUrl, function (data) {
        $.each(data, function (index, value) {
            //events.append('<div class="external-event ' + data[index].Bgcolor + '">' + data[index].Name + '</div>');
            var currColor = data[index].Bgcolor;
            var val = data[index].Name;
            if (val.length == 0) {
                return;
            }
            // Create events
            var event = $("<div />");
            event.css({ "background-color": currColor, "border-color": currColor, "color": "#fff" }).addClass("external-event");
            event.html(val);
            $('#external-events').prepend(event);
            //Add draggable funtionality
            ini_events(event);
            //Remove event from text input
            $("#new-event").val("");
        });
    });
};


// This is a simple *viewmodel* - JavaScript that defines the data and behavior of your UI
function AppViewModel() {
    var me = this;
    me.title = ko.observable("");
    me.Sdate = ko.observable("");
    me.Edate = ko.observable("");
    me.Bgcolor = ko.observable("");

    if (me.title.length < 1 || me.Sdate.length < 1 || me.Edate.length < 1 || me.Bgcolor.length < 1) {
        return;
    }
    this.calendar.fullCalendar({
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        buttonText: {
            today: 'today',
            month: 'month',
            week: 'week',
            day: 'day'
        },
        //Random default events
        events: [{
            title: me.title,
            start: me.Sdate,
            end: me.Edate,
            backgroundColor: me.Bgcolor,
            borderColor: me.Bgcolor
        }],
        editable: true,
        droppable: true, // this allows things to be dropped onto the calendar !!!
        drop: function (date, allDay) { // this function is called when something is dropped

            // retrieve the dropped element's stored Event Object
            var originalEventObject = $(this).data('eventObject');

            // we need to copy it, so that multiple events don't have a reference to the same object
            var copiedEventObject = $.extend({}, originalEventObject);

            // assign it the date that was reported
            copiedEventObject.start = date;
            copiedEventObject.allDay = allDay;
            copiedEventObject.backgroundColor = $(this).css("background-color");
            copiedEventObject.borderColor = $(this).css("border-color");

            // render the event on the calendar
            // the last `true` argument determines if the event "sticks" (http://arshaw.com/fullcalendar/docs/event_rendering/renderEvent/)
            $('#calendar').fullCalendar('renderEvent', copiedEventObject, true);

            // is the "remove after drop" checkbox checked?
            if ($('#drop-remove').is(':checked')) {
                // if so, remove the element from the "Draggable Events" list
                $(this).remove();
            }

        }
    });
}

// Activates knockout.js
ko.applyBindings(new AppViewModel());
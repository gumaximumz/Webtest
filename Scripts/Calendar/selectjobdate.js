
SelectCalendarDate = function () {
    var me = this;
    this.GetCalendar = [];
    this.getUrl = '';
    this.calendar = new Calendar();
}
SelectCalendarDate.prototype.init = function () {
    var me = this;
    $.get(this.getUrl, function (data) {
        me.calendar.crateCalendar(data);
    });
}
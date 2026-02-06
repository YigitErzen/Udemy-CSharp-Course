
var printer = new MedicalAppointmentPrinter();

var appointment1 = new MedicalAppointment("John Doe");
appointment1.Print(printer);

var appointment2 = new MedicalAppointment("Jane Smith", new DateTime(2026, 3, 15));
appointment2.Print(printer);

var appointment3 = new MedicalAppointment("Bob Johnson", 7);
appointment3.Print(printer);

appointment2.Reschedule(new DateTime(2026, 5, 10));
appointment2.Print(printer);

appointment2.Reschedule(6, 15);
appointment2.Print(printer);

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName)
    {
        _patientName = patientName;
        _date = DateTime.Now;
    }

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName, int daysFromToday)
        : this(patientName, DateTime.Now.AddDays(daysFromToday))
    {
    }

    public void Reschedule(DateTime date)
    {
        this._date = date;
    }

    public void Reschedule(int month, int day)
    {
        this._date = new DateTime(_date.Year, month, day);
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public string GetPatientName()
    {
        return _patientName;
    }

    public void Print(MedicalAppointmentPrinter printer)
    {
        printer.Print(this);
    }
}

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment appointment)
    {
        Console.WriteLine($"Appointment for {appointment.GetPatientName()} will take place on {appointment.GetDate():yyyy-MM-dd}");
    }
}

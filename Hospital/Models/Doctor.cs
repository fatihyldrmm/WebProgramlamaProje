namespace Hospital.Models
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Enum MyProperty { get; set; }

    }

    public enum Gunler
    {
        pzts = 10,
        sali,
        cars,
        pers,
        cuma,
        cmts,
        pazar
    }
}

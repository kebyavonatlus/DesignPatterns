namespace FunctionalBuilder
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAs(this PersonBuilder builder, string positios) =>
            builder.Do(p => p.Position = positios);
    }
}

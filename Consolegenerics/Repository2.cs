namespace ConsoleGenerics
{
    public class Repository2
    {
        public Result Add(object item)
        {
            //llamar a una bbdd
            return new Result()
            {
                Ok=true,
                Item=item
            };
        }
    }

    public class Result
    {
        public bool Ok { get; set; }

        public object Item { get; set; }
    }
}

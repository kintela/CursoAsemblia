namespace ConsoleGenerics
{
    public class Repository
    {
        public Result<T> Add<T>(T item)
        {
            //llamar a una bbdd
            return new Result<T>()
            {
                Ok=true,
                Item=item
            };

        }

        //public object FindById2(object item, int id)
        //{
        //    if (item.Id == id)
        //        return item;
        //    else
        //        return null;
        //}

        public T FindById<T>(T item, int id)
            where T:IIdentity
        {
            
            if (item.Id == id)
                return item;
            else
                return default(T);
        }

        public T Create<T>()
            where T:new()
        {
            return new T();
        }

    }

    public class Result<T>
    {
        public bool Ok { get; set; }

        public T Item { get; set; }
    }
}

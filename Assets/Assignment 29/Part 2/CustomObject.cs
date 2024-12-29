namespace Assignment29
{
    public class CustomObject
    {
        int id;
        string name;
        public CustomObject(int id , string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return $"Object [ID: {id}, Name: {name}]";
        }
        public override bool Equals(object obj)
        {
            if (obj is CustomObject ismail)
            {
                return this.id == ismail.id && this.name == ismail.name;
            }
            else 
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            return obj1.id == obj2.id && obj1.name == obj2.name;
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            return obj1.id != obj2.id && obj1.name != obj2.name;
        }
    }
}
    

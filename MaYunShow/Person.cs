namespace MaYunShow
{
    public class Person
    {
        public string m_name;
        public int m_age;

        public override string ToString()
        {
            return string.Format("{0} {1}", m_name, m_age);
        }
    }
}
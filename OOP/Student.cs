namespace OOP
{
    class Student
    {
        /*
         * 字段 属性二者使用起来并无二致，
         * 但根据framework design guideline准则，字段不能暴露，可通过属性去get//set,且存在属性时字段会自动创建，故省略了字段的声明
         * 例如：给id字段赋值-1时，可在其属性中做验证
        */
        //private int id;                    字段
        public int Id { get; set; }       //属性，隐藏字段的简写
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
    }
}

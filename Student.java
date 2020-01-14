class Student{  
    int id;  
    String name;  
    int age;
    String addr;  
    //creating two arg constructor  
    public Student(int i,String n){  
    id = i;  
    name = n;  
    }  
    //creating three arg constructor  
    Student(int i,String n,int a){  
    id = i;  
    name = n;  
    age=a;  
    }  
    protected Student(int id,String n,int a,String addr){
       this.id=id;
       name=n;
       age=a;
       this.addr=addr;
}
    void display(){System.out.println(id+" "+name+" "+age+addr);}  
   
    public static void main(String args[]){  
    Student s1 = new Student(111,"Karan");  
    Student s2 = new Student(222,"Aryan",25);  
    Student s3 = new Student(333,"Arnold",28,"Gachibowli");
     Student s4=new Student();
        s4.id=111;
        s4.name='Viv";
    s1.display();  
    s2.display();  
s3.display();

   }  
}  

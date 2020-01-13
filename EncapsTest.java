class Book{
    private int bookId;
    private String bookName;
    private int edition;
    private String author;

    //Getter and Setter methods
    public int getBookId(){
        return bookId;
    }

    public String getbookName(){
        return bookName;
    }

    public int getEdition(){
        return edition;
    }
    public String getAuthor(){
        return author;
    }

    public void setBookId(int bookId){
       this.bookId=bookId;
    }

    public void setbookName(String bookName){
        this.bookName = bookName;
    }

    public void setEdition(int edition){
        this.edition= edition;
    }
   public void setAuthor(String author){
        this.author = author;
    }
}
public class EncapsTest{
    public static void main(String args[]){
         Book obj = new Book();
         obj.setbookName("GodFather");
         obj.setEdition(32);
         obj.setBookId(5);
         obj.setAuthor("Mario Puzo");
         System.out.println("Book Name: " + obj.getbookName());
         System.out.println("Book Id: " + obj.getBookId());
         System.out.println("Book Edition: " + obj.getEdition());
         System.out.println("Book Author: " + obj.getAuthor());
    } 
}
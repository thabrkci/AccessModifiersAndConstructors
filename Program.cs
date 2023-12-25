        Console.WriteLine("Erişim Belirleyiciler ve Kurucu Fonksiyonlar");
        Console.WriteLine("Personel 1:");

        Shopping personellist = new Shopping("Taha","BÖREKCİ",351,"Sales");/*Personel 3 kod bloğunda uzun uzaya shoppersonel metodunu kullanmak yerine daha temiz ve kısa b
        bir şekilde kullandık.*/
        personellist.shoppersonel();

        Console.WriteLine("*****************************************************");/*Burada ise işe yeni başlayan bir personelin sadece
        adı ve soyadı belli olduğu için bu girdileri kullandık.*/
        Shopping personellist2 = new Shopping("Hakan","BULUT");
        personellist.shoppersonel();

        Console.WriteLine("*********Personel 3******************");
        Shopping personellist3 = new Shopping();
        personellist2.name= "Barış";
        personellist2.surname= "AKAN";
        personellist.personelno=355;
        personellist2.department="administrator";
        personellist2.shoppersonel();
        


    


class Shopping
{

public string name;
public string surname;
public int personelno;
public string department;

public Shopping(string Name, string Surname, int Personelno, string Department)
{
  this.name = Name;
  this.surname = Surname;
  this.personelno = Personelno;
  this.department = Department;


}

public Shopping(string Name,string Surname)//Yukarıdaki Shopping metodunun kısaltılmış hali hem temiz hemde daha az yer kaplıyor.

{
    this.name=Name;
    this.surname=Surname;

}
public Shopping(){}//Alttaki shoppersonel metodunun hata vermemesi adına yazılması gerekiyor.


public void shoppersonel()//Mağaza personel bilgilerini yazdıran metot
{
   Console.WriteLine("Personel name:{0}",name);
   Console.WriteLine("Personel surname:{0}",surname);
   Console.WriteLine("Personel PersonelNo:{0}",personelno);
   Console.WriteLine("Personel department:{0}",department);

}




}
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
//        String tekst = "Moniczka";
//        int x = 67;
//        double y = 67.67676767;
//
//        System.out.print("\n\n"+tekst+"\n");
//        System.out.printf("%d",x);
//        System.out.printf("\n%f",y);
//        System.out.printf("\n% .3f", y);
//        System.out.printf("\n%10d",x);
//        System.out.printf("\n%12s",tekst);


        Scanner scanner = new Scanner(System.in);

        int wiek;
        String imie, nazwisko;
        System.out.println("Podaj imie: ");
        imie = scanner.nextLine();
        System.out.println("Podaj nazwisko");
        nazwisko = scanner.nextLine();
        System.out.println("podaj wiek");
        wiek = scanner.nextInt();
        System.out.println("imie: "+imie+" nazwisko: "+ nazwisko+ " wiek: "+ wiek);

    }
}
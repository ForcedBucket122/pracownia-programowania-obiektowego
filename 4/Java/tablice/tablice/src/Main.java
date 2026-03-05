import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("1. Tablice jednowymiarowe nacisnij enter");
        String text = scanner.nextLine();

        int[] tablica1 = new int[10];
        int[] tablica2 = new int[]{1,24,5,2,645};
        int[] tablica3 = {1,24,5,2,645};

        wyswietlTablice(tablica1);
        wyswietlTablice(tablica2);
        wyswietlamyForeachem(tablica3);

        System.out.println("1. Tablice z obsługą błędów nacisnij enter");
        text = scanner.nextLine();

        try {
            System.out.println("Podaj indeks tablicy");
            int index = Integer.parseInt(scanner.nextLine());
            System.out.println(tablica1[index]);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void wyswietlTablice(int[] tablica){
        for (int i = 0; i < tablica.length; i++) {
            System.out.print(tablica[i] + ", ");
        }
        System.out.println("");
    }

    public static void wyswietlamyForeachem(int[] tablica){
        for (int x: tablica){
            System.out.print(x + ", ");
        }
        System.out.println();
    }
    public static void wypelnianieLosowymi(int[] tablica){

    }
}
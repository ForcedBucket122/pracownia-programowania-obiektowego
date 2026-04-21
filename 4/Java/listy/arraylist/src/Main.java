import java.util.*;

public class Main {
    public static void main(String[] args) {

        LinkedList<Integer> linkedList = new LinkedList<>();
        ArrayList<Integer> arrayList = new ArrayList<>();

        fillList(arrayList, 5);
        fillList(linkedList, 5);

        printList(arrayList);
        printList(linkedList);

    }

    public static void fillList(ArrayList<Integer> list, int bound){
        Random r = new Random();
        for (int i =0; i<bound; i++){
            list.add(r.nextInt());
        }
    }
    public static void fillList(LinkedList<Integer> list, int bound){
        Random r = new Random();
        for (int i =0; i<bound; i++){
            list.add(r.nextInt());
        }
    }
    public static void printList(ArrayList<Integer> list){
        for(int i: list){
            System.out.println(i);
        }
    }
     public static void printList(LinkedList<Integer> list){
        for(int i: list){
            System.out.println(i);
        }
    }
}
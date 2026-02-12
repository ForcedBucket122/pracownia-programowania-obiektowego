package p1;

public class B {

    private static String BPrivate = "B private";
    protected static String BProtected = "B protected";
    public static String BPublic = "B public";
    static String BPrivate_Package = "B private package";

    public static void metodaB(){
        System.out.println(BPrivate);
        System.out.println(BProtected);
        System.out.println(BPublic);
        System.out.println(BPrivate_Package);
    }
}

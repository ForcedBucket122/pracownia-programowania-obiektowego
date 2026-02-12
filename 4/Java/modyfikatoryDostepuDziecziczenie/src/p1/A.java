package p1;

public class A {
    private static String APrivate = "A private";
    protected static String AProtected = "A protected";
    public static String APublic = "A public";
    static String APrivate_Package = "A private package";

    public static void metodaA(){
        System.out.println(APrivate);
        System.out.println(AProtected);
        System.out.println(APublic);
        System.out.println(APrivate_Package);
    }

}

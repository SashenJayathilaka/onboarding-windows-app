class P {
    static void Main() {
        int[] n = { 1, 2, 3, 4, 5 };
        int s = 0;
        for (int i = 0; i < n.Length; i++) {
            s = s + n[i];
        }
        System.Console.WriteLine(s);
    }
}
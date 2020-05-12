using System.Runtime.InteropServices;

public static class VisualStudioLibWrapper
{
    [DllImport("2020_5A_AL2_Library_VisualStudio_Cpp")]
    public static extern int my_add(int x, int y);
    
    [DllImport("2020_5A_AL2_Library_VisualStudio_Cpp")]
    public static extern int my_mul(int x, int y);


}
using System.Runtime.InteropServices;
using System;
public static class CLionLibWrapper
{
    [DllImport("2020_5A_AL2_MachineLearning_Lib_CLion")]
    public static extern int my_add(int x, int y);
    
    [DllImport("2020_5A_AL2_MachineLearning_Lib_CLion")]
    public static extern int my_mul(int x, int y);
	
	[DllImport("lib")]
	public static extern int my_test(int x, int y, int z);

	[DllImport("lib")]
	public static extern IntPtr linear_model_create(int input_dim);
	
	[DllImport("lib")]
    public static extern double linear_model_predict_regression(IntPtr model, double[] inputs, int inputs_size);//
	
	[DllImport("lib")]
	public static extern double linear_model_predict_classification(IntPtr model, double[] inputs, int inputs_size);//
	
	[DllImport("lib")]
	public static extern void linear_model_train_classification(IntPtr model,
            double[] dataset_inputs,
            int dataset_length,
            int inputs_size,
            double[] dataset_expected_outputs,
            int outputs_size,
            int iterations_count,
            float alpha);
	
	[DllImport("lib")]
	public static extern void linear_model_train_regression(IntPtr model,
        double[] dataset_inputs,
        int dataset_length,
        int inputs_size,
        double[] dataset_expected_outputs,
        int outputs_size);

	[DllImport("lib")]
	public static extern double[] lines_sum(double[] lines, int lines_count, int line_size);

}
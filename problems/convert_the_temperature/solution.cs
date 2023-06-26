public class Solution {
    public double[] ConvertTemperature(double celsius) => 
        new double[2] {celsius + 273.15, celsius * 1.80 + 32.00};
}
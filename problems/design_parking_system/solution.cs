public class ParkingSystem {
    private int[] Slots = new int[3];

    public ParkingSystem(int big, int medium, int small) {
        Slots[0] = big; Slots[1] = medium; Slots[2] = small;
    }
    
    public bool AddCar(int carType) => (Slots[carType - 1]-- > 0) ? true : false;
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
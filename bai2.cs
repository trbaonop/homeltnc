using System;

class ArrayProcessor
{
    private int[] arr = new int[0];

    // Nhập mảng từ bàn phím
    public void Input()
    {
        Console.Write("Nhập số phần tử của mảng: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Sai, nhập lại số nguyên dương: ");
        }

        arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            while (!int.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.Write("Sai, nhập lại số nguyên: ");
            }
        }
    }

    // Hiển thị mảng
    public void Display()
    {
        if (arr.Length == 0)
        {
            Console.WriteLine("Mảng rỗng!");
            return;
        }
        Console.WriteLine(string.Join(" ", arr));
    }

    // Bubble Sort tăng dần
    public void BubbleSort()
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Hoán đổi
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Quick Sort
    public void QuickSort(int left, int right)
    {
        if (left >= right) return;

        int pivot = arr[(left + right) / 2];
        int i = left, j = right;

        while (i <= j)
        {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot) j--;
            if (i <= j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }

        if (left < j) QuickSort(left, j);
        if (i < right) QuickSort(i, right);
    }

    // Linear Search
    public int LinearSearch(int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key) return i;
        }
        return -1;
    }

    // Binary Search (yêu cầu mảng đã sắp xếp)
    public int BinarySearch(int key)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == key) return mid;
            if (arr[mid] < key) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    // Lấy độ dài mảng
    public int Length()
    {
        return arr.Length;
    }
}

class MainApp
{
    static void Main()
    {
        ArrayProcessor ap = new ArrayProcessor();

        // Nhập mảng
        ap.Input();

        Console.WriteLine("\n--- Mảng ban đầu ---");
        ap.Display();

        // Sắp xếp bằng Bubble Sort
        ap.BubbleSort();
        Console.WriteLine("\n--- Sau Bubble Sort ---");
        ap.Display();

        // Sắp xếp lại bằng Quick Sort (trước tiên nhập lại mảng)
        Console.WriteLine("\nNhập lại mảng để Quick Sort:");
        ap.Input();
        Console.WriteLine("\n--- Mảng ban đầu ---");
        ap.Display();

        ap.QuickSort(0, ap.Length() - 1);
        Console.WriteLine("\n--- Sau Quick Sort ---");
        ap.Display();

        // Tìm kiếm
        Console.Write("\nNhập số cần tìm: ");
        int key;
        while (!int.TryParse(Console.ReadLine(), out key))
        {
            Console.Write("Sai, nhập lại số nguyên: ");
        }

        int posLinear = ap.LinearSearch(key);
        Console.WriteLine(posLinear >= 0
            ? $"Linear Search: tìm thấy {key} tại vị trí {posLinear}"
            : $"Linear Search: không tìm thấy {key}");

        int posBinary = ap.BinarySearch(key);
        Console.WriteLine(posBinary >= 0
            ? $"Binary Search: tìm thấy {key} tại vị trí {posBinary}"
            : $"Binary Search: không tìm thấy {key}");
    }
}

using System;

class MatrixProgram
{
    static void Main()
    {
        Console.WriteLine("=== CHƯƠNG TRÌNH XỬ LÝ MA TRẬN ===");

        // Nhập ma trận A
        int[,] A = InputMatrix("A");

        // Nhập ma trận B
        int[,] B = InputMatrix("B");

        Console.WriteLine("\n--- Ma trận A ---");
        PrintMatrix(A);

        Console.WriteLine("\n--- Ma trận B ---");
        PrintMatrix(B);

        // Cộng ma trận
        Console.WriteLine("\n--- A + B ---");
        int[,] sum = AddMatrix(A, B);
        if (sum.Length != 0) PrintMatrix(sum);

        // Nhân ma trận
        Console.WriteLine("\n--- A × B ---");
        int[,] product = MultiplyMatrix(A, B);
        if (product.Length != 0) PrintMatrix(product);

        // Chuyển vị A
        Console.WriteLine("\n--- Aᵀ ---");
        PrintMatrix(TransposeMatrix(A));

        // Giá trị lớn nhất & nhỏ nhất của A
        (int maxVal, int minVal) = FindMaxMin(A);
        Console.WriteLine($"\nPhần tử lớn nhất của A: {maxVal}");
        Console.WriteLine($"Phần tử nhỏ nhất của A: {minVal}");

        // Kiểm tra đối xứng
        Console.WriteLine($"\nMa trận A {(IsSymmetric(A) ? "đối xứng" : "không đối xứng")}");
    }

    // Nhập ma trận
    static int[,] InputMatrix(string name)
    {
        Console.WriteLine($"\nNhập ma trận {name}");
        int rows = ReadInt("Nhập số dòng: ");
        int cols = ReadInt("Nhập số cột: ");

        int[,] matrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = ReadInt($"{name}[{i},{j}] = ");
            }
        }
        return matrix;
    }

    // In ma trận
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows == 0 || cols == 0)
        {
            Console.WriteLine("Ma trận rỗng!");
            return;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }

    // Cộng 2 ma trận
    static int[,] AddMatrix(int[,] A, int[,] B)
    {
        if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
        {
            Console.WriteLine("Không thể cộng 2 ma trận (kích thước khác nhau)");
            return new int[0, 0];
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = A[i, j] + B[i, j];

        return result;
    }

    // Nhân 2 ma trận
    static int[,] MultiplyMatrix(int[,] A, int[,] B)
    {
        int aRows = A.GetLength(0);
        int aCols = A.GetLength(1);
        int bRows = B.GetLength(0);
        int bCols = B.GetLength(1);

        if (aCols != bRows)
        {
            Console.WriteLine("Không thể nhân 2 ma trận (số cột A ≠ số dòng B)");
            return new int[0, 0]; // ma trận rỗng
        }

        int[,] result = new int[aRows, bCols];

        for (int i = 0; i < aRows; i++)
            for (int j = 0; j < bCols; j++)
                for (int k = 0; k < aCols; k++)
                    result[i, j] += A[i, k] * B[k, j];

        return result;
    }

    // Chuyển vị
    static int[,] TransposeMatrix(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        int[,] result = new int[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[j, i] = A[i, j];

        return result;
    }

    // Tìm max, min
    static (int, int) FindMaxMin(int[,] A)
    {
        int maxVal = A[0, 0], minVal = A[0, 0];
        foreach (int val in A)
        {
            if (val > maxVal) maxVal = val;
            if (val < minVal) minVal = val;
        }
        return (maxVal, minVal);
    }

    // Kiểm tra đối xứng
    static bool IsSymmetric(int[,] A)
    {
        int rows = A.GetLength(0);
        int cols = A.GetLength(1);

        if (rows != cols) return false;

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (A[i, j] != A[j, i]) return false;

        return true;
    }

    // Hàm nhập số nguyên an toàn
    static int ReadInt(string message)
    {
        int result;
        Console.Write(message);
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write("Nhập sai, vui lòng nhập lại: ");
        }
        return result;
    }
}

namespace AlgorytmyStrukturyDanych;

public class SortingAlgorithms
{
    public class InsertionSort {
        public void sort(int[] arr) {
            int n = arr.Length;
            for (int i = 1; i < n; ++i) {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key) {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        static void printArray(int[] arr) {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }

    public class MergeSort {
        public void sort(int[] arr, int l, int r) {
            if (l < r) {
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        void merge(int[] arr, int l, int m, int r) {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (int j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            int i1 = 0, j1 = 0;
            int k = l;
            while (i1 < n1 && j1 < n2) {
                if (L[i1] <= R[j1]) {
                    arr[k] = L[i1];
                    i1++;
                } else {
                    arr[k] = R[j1];
                    j1++;
                }
                k++;
            }

            while (i1 < n1) {
                arr[k] = L[i1];
                i1++;
                k++;
            }

            while (j1 < n2) {
                arr[k] = R[j1];
                j1++;
                k++;
            }
        }
    }
    
    public class QuickSort {
        public void sort(int[] arr, int low, int high) {
            if (low < high) {
                int pi = partition(arr, low, high);

                sort(arr, low, pi - 1);
                sort(arr, pi + 1, high);
            }
        }

        int partition(int[] arr, int low, int high) {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++) {
                if (arr[j] < pivot) {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
using System.Runtime.InteropServices;

namespace ProjectData{

	public unsafe struct DATA {
		public double a;
		public double b;
		public double *p_a;
	}
	
	class Program {

		[DllImport("libdata", CallingConvention = CallingConvention.Cdecl)]
    		public static extern DATA init_data(double a, double b);

		static unsafe int Main(){
			DATA data = init_data(1,2);

			Console.WriteLine($"A: {data.a}\nB: {data.b}");

			return 0;
		}
		
	}
}

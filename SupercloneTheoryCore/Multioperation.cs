using System;
namespace SupercloneTheoryCore
{
	public abstract class Multioperation
	{
        protected int _decimalRepresentation;
		protected int _arity;
		protected int _rank;

		public int Arity => _arity;
		public int Rank => _rank;
		public int DecimalRepresentation => _decimalRepresentation;
		public int VectorFormLength => vectorForm.Length;

		protected int[] vectorForm;

		public Multioperation()
		{
			_arity = int.MinValue;
			_rank = int.MinValue;
			_decimalRepresentation = 0;
		}

		public Multioperation(int[] vectorForm)
		{
			this.vectorForm = (int[])vectorForm.Clone();
		}

		public Multioperation(int decimalRepresentation)
		{
			if (decimalRepresentation < 0)
			{
				throw new System.ArgumentException("Parameter cannot be negative", "decimalRepresentation");
			}
			_decimalRepresentation = decimalRepresentation;
		}


		public override string ToString()
		{
			string info = "Multioperation: (";
			foreach (int i in vectorForm)
			{
				info += i.ToString() + ",";
			}
			info.Remove(info.Length - 1);
			info += ")";
			return info;
		}

		protected int[] CalculateVectorForm(int decimalRepresentation)
		{
			int[] result = new int[VectorFormLength];
			for (int i = 0; i < VectorFormLength; i++)
			{
				//result[i] = decimalRepresentation / 
			}
			return result;
		}

		private int CalculateDecimalRepresentation(int[] vectorForm)
		{
			int result = 0;
			for (int i = 0; i < vectorForm.Length; i++)
			{
				result += (int)Math.Pow(Rank, vectorForm.Length - i - 1) * vectorForm[i];
			}
			return result;
		}
	}
}

using System;

namespace Cuplex.ImageProvider
{
	/// <summary>
	/// Class BrightnessCornerInfo.
	/// </summary>
	internal class BrightnessCornerInfo
	{
		/// <summary>
		/// To v�
		/// </summary>
		public MinMaxMedBrightness ToV� = new MinMaxMedBrightness();
		/// <summary>
		/// To h�
		/// </summary>
		public MinMaxMedBrightness ToH� = new MinMaxMedBrightness();
		/// <summary>
		/// The bo v�
		/// </summary>
		public MinMaxMedBrightness BoV� = new MinMaxMedBrightness();
		/// <summary>
		/// The bo h�
		/// </summary>
		public MinMaxMedBrightness BoH� = new MinMaxMedBrightness();

		/// <summary>
		/// Gets the maximum medium brightness.
		/// </summary>
		/// <value>The maximum medium brightness.</value>
		public float MaxMediumBrightness
		{
			get
			{
				var maxMediumBrightness = Math.Max(ToV�.Med, ToH�.Med);
				maxMediumBrightness = Math.Max(maxMediumBrightness, BoV�.Med);
				maxMediumBrightness = Math.Max(maxMediumBrightness, BoH�.Med);

				return maxMediumBrightness;
			}
		}

		/// <summary>
		/// Gets the minimum medium brightness.
		/// </summary>
		/// <value>The minimum medium brightness.</value>
		public float MinMediumBrightness
		{
			get
			{
				var minMediumBrightness = Math.Min(ToV�.Med, ToH�.Med);
				minMediumBrightness = Math.Min(minMediumBrightness, BoV�.Med);
				minMediumBrightness = Math.Min(minMediumBrightness, BoH�.Med);
				return minMediumBrightness;
			}
		}

		/// <summary>
		/// Gets the maximum po�ng.
		/// </summary>
		/// <value>The maximum po�ng.</value>
		public float MaxPo�ng
		{
			get
			{
				var maxPo�ng = Math.Max(ToV�.Po�ng, ToH�.Po�ng);
				maxPo�ng = Math.Max(maxPo�ng, BoV�.Po�ng);
				maxPo�ng = Math.Max(maxPo�ng, BoH�.Po�ng);
				return maxPo�ng;
			}
		}

		/// <summary>
		/// Gets the maximum po�ng H�RN.
		/// </summary>
		/// <value>The maximum po�ng H�RN.</value>
		public int MaxPo�ngH�rn
		{
			get
			{
				var maxPo�ng = MaxPo�ng;
				var preferredCorner = 0;

				if (maxPo�ng == ToH�.Po�ng) preferredCorner = 2;
				if (maxPo�ng == ToV�.Po�ng) preferredCorner = 1;
				if (maxPo�ng == BoH�.Po�ng) preferredCorner = 4;
				if (maxPo�ng == BoV�.Po�ng) preferredCorner = 3;

				/*throw new Exception("Fel i MaxPo�ngH�rn this.toh�.po�ng: " + this.ToH�.Po�ng.ToString() 
					+ " " + this.ToV�.Po�ng.ToString() 
					+ " " + this.BoH�.Po�ng.ToString()
					+ " " + this.BoV�.Po�ng.ToString()
					+ " maxPo�ng: " + maxPo�ng.ToString()
					+ " h�rn: " + PreferredCorner.ToString());*/

				return preferredCorner;
			}
		}

		/// <summary>
		/// Gets the minimum medium brightness corner.
		/// </summary>
		/// <value>The minimum medium brightness corner.</value>
		public int MinMediumBrightnessCorner
		{
			get
			{
				var minMediumBrightness = MinMediumBrightness;
				var preferredCorner = 0;

				if (minMediumBrightness == ToH�.Min) preferredCorner = 2;
				if (minMediumBrightness == ToV�.Min) preferredCorner = 1;
				if (minMediumBrightness == BoH�.Min) preferredCorner = 4;
				if (minMediumBrightness == BoV�.Min) preferredCorner = 3;

				return preferredCorner;
			}
		}

		/// <summary>
		/// Gets the maximum medium brightness corner.
		/// </summary>
		/// <value>The maximum medium brightness corner.</value>
		public int MaxMediumBrightnessCorner
		{
			get
			{
				var maxMediumBrightness = MaxMediumBrightness;
				var preferredCorner = 0;

				if (maxMediumBrightness == ToH�.Max) preferredCorner = 2;
				if (maxMediumBrightness == ToV�.Max) preferredCorner = 1;
				if (maxMediumBrightness == BoH�.Max) preferredCorner = 4;
				if (maxMediumBrightness == BoV�.Max) preferredCorner = 3;

				return preferredCorner;
			}
		}
	}
}
using System;

namespace Cuplex.Common.ImageProvider
{
	/// <summary>
	/// Class MinMaxMedBrightness.
	/// </summary>
	internal class MinMaxMedBrightness
	{
		/// <summary>
		/// Gets or sets the maximum.
		/// </summary>
		/// <value>The maximum.</value>
		internal float Max { get; set; }

		/// <summary>
		/// Gets or sets the minimum.
		/// </summary>
		/// <value>The minimum.</value>
		internal float Min { get; set; }

		/// <summary>
		/// Gets or sets the med.
		/// </summary>
		/// <value>The med.</value>
		internal float Med { get; set; }

		/// <summary>
		/// Gets the luminans avvikelse.
		/// </summary>
		/// <value>The luminans avvikelse.</value>
		internal float LuminansAvvikelse => (Max - Min);

		/// <summary>
		/// Returnerar en po�ng f�r hur bra h�rnet l�mpar sig f�r att
		/// skriva texten i.
		/// </summary>
		/// <value>The po�ng.</value>
		internal float Po�ng
		{
			get
			{
				// Anger luminansavvikelsen som ett flyttal mellan 0 och 1
				// d�r h�gre tal inneb�r mindre avvikelse = positivt f�r att skriva text
				// 0 = Negativt, luminansen varierar v�ldigt mycket.
				// 1 = Positivt. Luminansen �r helt stabil och varierar inte alls
				var positivLuminansAvvikelse = 1f - (Max - Min);

				// Anger extremiteten f�r medelluminansen.
				// 0 = Negativt, luminansen �r gr�aktig
				// 1 = Positivt, luminansen �r antingen helt svart, eller helt vit
				var extremMedelLuminans = Math.Abs(Med - 0.5f) * 2f;

				// L�gg p� "Bias"
				positivLuminansAvvikelse += 1;
				extremMedelLuminans += 1;

				// Experimentera med viktning
				positivLuminansAvvikelse = positivLuminansAvvikelse * 5;    // Hur viktigt det �r med j�mn luminans
				extremMedelLuminans = extremMedelLuminans * 3;              // Hur viktigt det �r med h�g kontrast (mkt svart eller vitt)

				// Returnerad po�ng �r en sammanr�kning av hur positivt det �r
				// att skriva text i h�rnet.
				return positivLuminansAvvikelse + extremMedelLuminans;
			}
		}
	}
}
﻿namespace MVCIntroDemo.Models
{
	/// <summary>
	/// Product Model
	/// </summary>
	public class ProductViewModel
	{
		/// <summary>
		/// Product Identifier
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Product Name
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Product Price
		/// </summary>
		public int Price { get; set; }
	}
}

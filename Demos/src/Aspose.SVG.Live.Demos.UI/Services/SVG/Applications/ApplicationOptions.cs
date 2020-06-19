using System;
using System.Collections.Generic;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Conversion;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Merger;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG.Applications
{
	public abstract class ApplicationOptions : Dictionary<string, string>
	{
		public const string OPTION_INPUT_TYPE = "inputType";
		public const string OPTION_OUTPUT_TYPE = "outputType";

		protected ApplicationOptions()
		{}

		protected ApplicationOptions(IDictionary<string, string> @params)
			: base(@params)
		{ }

		protected T GetValueOrDefault<T>(string key, T @default)
		{
			if (ContainsKey(key))
				return (T)Convert.ChangeType(this[key], typeof(T));
			return @default;
		}

		protected T GetValueOrDefault<T>(string key)
		{
			return GetValueOrDefault<T>(key, default(T));
		}

		protected void SetValue<T>(string key, T value)
		{
			this[key] = value.ToString();
		}

		public abstract class Factory
		{
			public abstract ConversionApplicationOptions CreateConversionOptions(FileFormat inputFormat, FileFormat outputFormat, bool merge);
			public abstract ConversionApplicationOptions CreateConversionOptions();

			public abstract MergerApplicationOptions CreateMergerOptions(FileFormat inputFormat, FileFormat outputFormat);
			public abstract MergerApplicationOptions CreateMergerOptions();
		}

	}
}

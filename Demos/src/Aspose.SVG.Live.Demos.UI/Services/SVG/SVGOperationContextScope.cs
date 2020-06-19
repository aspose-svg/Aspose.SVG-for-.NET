using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.ServiceModel;
using Aspose.SVG.Live.Demos.UI.Services.Extensions;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Conversion;
using Aspose.SVG.Live.Demos.UI.Services.SVG.Applications.Merger;

namespace Aspose.SVG.Live.Demos.UI.Services.SVG
{
	public class SVGOperationContextScope : IDisposable
	{
		const string ID = "CONTEXT_ID";
		const string OUTPUT_FOLDER = "OUTPUT_FOLDER";
		const string INPUT_FOLDER = "INPUT_FOLDER";
		const string DELETE_SOURCE_FOLDER = "DELETE_SOURCE_FOLDER";
		const string PACK_IF_RESULT_HAS_MULPIPLE_FILES = "PACK_IF_RESULT_HAS_MULPIPLE_FILES";

		[ThreadStatic]
		static SVGOperationContext context;

		

		public SVGOperationContextScope(SVGService service)
			: this(service, new Dictionary<string, string>())

		{ }

		public SVGOperationContextScope(SVGService service, IDictionary<string, string> dictionary)
		{
			dictionary = SVGOperationContext.GetDefaults().Merge(dictionary, key => key.ToUpper());
			context = new SVGOperationContext(service, dictionary);
		}

		public static SVGOperationContext Context
		{
			get { return context; }
		}

		/// <summary>Releases unmanaged and - optionally - managed resources.</summary>
		/// <param name="disposing">
		///   <c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				context = null;
			}
		}

		/// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		public class SVGOperationContext : Dictionary<string, string>
		{
			public SVGOperationContext(SVGService service, IDictionary<string, string> dictionary)
				: base(dictionary)
			{
				this.Service = service;
				this.ApplicationOptionsFactory = new ApplicationOptionsFactoryImpl(this);
			}

			internal static IDictionary<string, string> GetDefaults()
			{
				var id = Guid.NewGuid().ToString();
				return new Dictionary<string, string>()
				{
					{ID, id},
					{OUTPUT_FOLDER, Path.GetFullPath(new PathProcessor(id, file: "", checkDefaultSourceFileExistence: false).OutFolder)},
					{INPUT_FOLDER, Path.GetFullPath(new PathProcessor(id).SourceFolder)},
					{PACK_IF_RESULT_HAS_MULPIPLE_FILES, bool.TrueString}
				};
			}

			public string Id
			{
				get { return this[ID]; }
			}

			public string OutputFolder
			{
				get { return this[OUTPUT_FOLDER]; }
			}

			public string InputFolder
			{
				get { return this[INPUT_FOLDER]; }
			}
			public bool DeleteSourceFolder
			{
				get { return GetValueOrDefault<bool>(DELETE_SOURCE_FOLDER); }
				set { SetValue(DELETE_SOURCE_FOLDER, value); }
			}

			public bool PackIfResultHasMultipleFiles
			{
				get { return GetValueOrDefault<bool>(PACK_IF_RESULT_HAS_MULPIPLE_FILES); }
				set { SetValue(PACK_IF_RESULT_HAS_MULPIPLE_FILES, value); }
			}

			public FileFormat InputFormat
			{
				get
				{
					var result = GetValueOrDefault<string>(ApplicationOptions.OPTION_INPUT_TYPE);
					if (string.IsNullOrEmpty(result))
						return FileFormat.Unknown;
					return (FileFormat)result;
				}
			}

			public SVGService Service { get; }

			public ApplicationOptions.Factory ApplicationOptionsFactory { get; }

			T GetValueOrDefault<T>(string key)
			{
				if (this.ContainsKey(key))
					return (T)Convert.ChangeType(this[key], typeof(T));
				return default(T);
			}

			void SetValue<T>(string key, T value)
			{
				this[key] = value.ToString();
			}

			class ApplicationOptionsFactoryImpl : ApplicationOptions.Factory
			{
				private readonly SVGOperationContext context;

				public ApplicationOptionsFactoryImpl(SVGOperationContext context)
				{
					this.context = context;
				}

				public override ConversionApplicationOptions CreateConversionOptions(FileFormat inputFormat, FileFormat outputFormat, bool merge)
				{
					return new ConversionApplicationOptions(inputFormat, outputFormat, merge, context);
				}

				public override ConversionApplicationOptions CreateConversionOptions()
				{
					return new ConversionApplicationOptions(context);
				}

				public override MergerApplicationOptions CreateMergerOptions(FileFormat inputFormat, FileFormat outputFormat)
				{
					return new MergerApplicationOptions(inputFormat, outputFormat, context);
				}

				public override MergerApplicationOptions CreateMergerOptions()
				{
					return new MergerApplicationOptions(context);
				}
			}
		}
	}
}

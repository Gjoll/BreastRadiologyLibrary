using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BreastBodyLocation' extension class.
	/// </summary>
	public class BreastBodyLocationExtension : MemberListExtensionComplex                                                                      // BuildMemberListExtension.cs:317
	{                                                                                                                                          // BuildMemberListExtension.cs:318
	    QuadrantExtension Quadrant;                                                                                                            // BuildMemberListExtension.cs:394
	    RegionExtension Region;                                                                                                                // BuildMemberListExtension.cs:394
	    ClockDirectionExtension ClockDirection;                                                                                                // BuildMemberListExtension.cs:394
	    DepthExtension Depth;                                                                                                                  // BuildMemberListExtension.cs:394
	                                                                                                                                           // BuildMemberListExtension.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension() : base("BreastBodyLocation")                                                                      // BuildMemberListExtension.cs:324
	    {                                                                                                                                      // BuildMemberListExtension.cs:325
	        this.Quadrant = new QuadrantExtension(this.doc);                                                                                   // BuildMemberListExtension.cs:397
	        this.Region = new RegionExtension(this.doc);                                                                                       // BuildMemberListExtension.cs:397
	        this.ClockDirection = new ClockDirectionExtension(this.doc);                                                                       // BuildMemberListExtension.cs:397
	        this.Depth = new DepthExtension(this.doc);                                                                                         // BuildMemberListExtension.cs:397
	    }                                                                                                                                      // BuildMemberListExtension.cs:327
	                                                                                                                                           // BuildMemberListExtension.cs:328
	    protected override void ReadItems(IEnumerable<Extension> e)                                                                            // BuildMemberListExtension.cs:329
	    {                                                                                                                                      // BuildMemberListExtension.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Quadrant.ReadItems(e);                                                                                                        // BuildMemberListExtension.cs:400
	        this.Region.ReadItems(e);                                                                                                          // BuildMemberListExtension.cs:400
	        this.ClockDirection.ReadItems(e);                                                                                                  // BuildMemberListExtension.cs:400
	        this.Depth.ReadItems(e);                                                                                                           // BuildMemberListExtension.cs:400
	    }                                                                                                                                      // BuildMemberListExtension.cs:335
	                                                                                                                                           // BuildMemberListExtension.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    protected override IEnumerable<Extension> WriteItems()                                                                                 // BuildMemberListExtension.cs:340
	    {                                                                                                                                      // BuildMemberListExtension.cs:341
	        List<Extension> retVal = new List<Extension>();                                                                                    // BuildMemberListExtension.cs:342
	        retVal.AddRange(this.Quadrant.WriteItems());                                                                                       // BuildMemberListExtension.cs:403
	        retVal.AddRange(this.Region.WriteItems());                                                                                         // BuildMemberListExtension.cs:403
	        retVal.AddRange(this.ClockDirection.WriteItems());                                                                                 // BuildMemberListExtension.cs:403
	        retVal.AddRange(this.Depth.WriteItems());                                                                                          // BuildMemberListExtension.cs:403
	        return retVal.ToArray();                                                                                                           // BuildMemberListExtension.cs:344
	    }                                                                                                                                      // BuildMemberListExtension.cs:345
	}                                                                                                                                          // BuildMemberListExtension.cs:346
	                                                                                                                                           // BuildMemberListExtension.cs:437
	/// <summary>
	/// Class that implements the QuadrantExtension' extension slice class.
	/// </summary>
	public class QuadrantExtension : MemberListExtensionSimple<CodeableConcept>                                                                // BuildMemberListExtension.cs:441
	{                                                                                                                                          // BuildMemberListExtension.cs:442
	                                                                                                                                           // BuildMemberListExtension.cs:468
	    /// <summary>
	    /// Get value of extension slice quadrant
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:472
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Set value of extension slice quadrant
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:446
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public QuadrantExtension(BreastRadiologyDocument doc) : base("QuadrantExtension")                                                      // BuildMemberListExtension.cs:450
	    {                                                                                                                                      // BuildMemberListExtension.cs:451
	        this.Init(doc, 0, 1, "quadrant");                                                                                                  // BuildMemberListExtension.cs:452
	    }                                                                                                                                      // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:457
	}                                                                                                                                          // BuildMemberListExtension.cs:458
	                                                                                                                                           // BuildMemberListExtension.cs:437
	/// <summary>
	/// Class that implements the RegionExtension' extension slice class.
	/// </summary>
	public class RegionExtension : MemberListExtensionSimple<CodeableConcept>                                                                  // BuildMemberListExtension.cs:441
	{                                                                                                                                          // BuildMemberListExtension.cs:442
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListExtension.cs:509
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListExtension.cs:515
	                                                                                                                                           // BuildMemberListExtension.cs:517
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListExtension.cs:521
	                                                                                                                                           // BuildMemberListExtension.cs:522
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListExtension.cs:526
	                                                                                                                                           // BuildMemberListExtension.cs:446
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RegionExtension(BreastRadiologyDocument doc) : base("RegionExtension")                                                          // BuildMemberListExtension.cs:450
	    {                                                                                                                                      // BuildMemberListExtension.cs:451
	        this.Init(doc, 0, -1, "region");                                                                                                   // BuildMemberListExtension.cs:452
	    }                                                                                                                                      // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:496
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                                // BuildMemberListExtension.cs:500
	                                                                                                                                           // BuildMemberListExtension.cs:496
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendCodeableConcept(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                 // BuildMemberListExtension.cs:500
	                                                                                                                                           // BuildMemberListExtension.cs:457
	}                                                                                                                                          // BuildMemberListExtension.cs:458
	                                                                                                                                           // BuildMemberListExtension.cs:437
	/// <summary>
	/// Class that implements the ClockDirectionExtension' extension slice class.
	/// </summary>
	public class ClockDirectionExtension : MemberListExtensionSimple<CodeableConcept>                                                          // BuildMemberListExtension.cs:441
	{                                                                                                                                          // BuildMemberListExtension.cs:442
	                                                                                                                                           // BuildMemberListExtension.cs:468
	    /// <summary>
	    /// Get value of extension slice clockDirection
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:472
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Set value of extension slice clockDirection
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:446
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ClockDirectionExtension(BreastRadiologyDocument doc) : base("ClockDirectionExtension")                                          // BuildMemberListExtension.cs:450
	    {                                                                                                                                      // BuildMemberListExtension.cs:451
	        this.Init(doc, 0, 1, "clockDirection");                                                                                            // BuildMemberListExtension.cs:452
	    }                                                                                                                                      // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:457
	}                                                                                                                                          // BuildMemberListExtension.cs:458
	                                                                                                                                           // BuildMemberListExtension.cs:437
	/// <summary>
	/// Class that implements the DepthExtension' extension slice class.
	/// </summary>
	public class DepthExtension : MemberListExtensionSimple<CodeableConcept>                                                                   // BuildMemberListExtension.cs:441
	{                                                                                                                                          // BuildMemberListExtension.cs:442
	                                                                                                                                           // BuildMemberListExtension.cs:468
	    /// <summary>
	    /// Get value of extension slice depth
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:472
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Set value of extension slice depth
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:446
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DepthExtension(BreastRadiologyDocument doc) : base("DepthExtension")                                                            // BuildMemberListExtension.cs:450
	    {                                                                                                                                      // BuildMemberListExtension.cs:451
	        this.Init(doc, 0, 1, "depth");                                                                                                     // BuildMemberListExtension.cs:452
	    }                                                                                                                                      // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:457
	}                                                                                                                                          // BuildMemberListExtension.cs:458
	//- LocalClassDefs
}

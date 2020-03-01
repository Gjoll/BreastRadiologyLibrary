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
	public class BreastBodyLocationExtension : MemberListExtension<IMemberListExtension>                                                       // BuildMemberListExtension.cs:317
	{                                                                                                                                          // BuildMemberListExtension.cs:318
	    QuadrantExtension Quadrant;                                                                                                            // BuildMemberListExtension.cs:392
	    RegionExtension Region;                                                                                                                // BuildMemberListExtension.cs:392
	    ClockDirectionExtension ClockDirection;                                                                                                // BuildMemberListExtension.cs:392
	    DepthExtension Depth;                                                                                                                  // BuildMemberListExtension.cs:392
	                                                                                                                                           // BuildMemberListExtension.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension() : base("BreastBodyLocation")                                                                      // BuildMemberListExtension.cs:324
	    {                                                                                                                                      // BuildMemberListExtension.cs:325
	        this.Quadrant = new QuadrantExtension(this.doc);                                                                                   // BuildMemberListExtension.cs:395
	        this.Region = new RegionExtension(this.doc);                                                                                       // BuildMemberListExtension.cs:395
	        this.ClockDirection = new ClockDirectionExtension(this.doc);                                                                       // BuildMemberListExtension.cs:395
	        this.Depth = new DepthExtension(this.doc);                                                                                         // BuildMemberListExtension.cs:395
	    }                                                                                                                                      // BuildMemberListExtension.cs:327
	                                                                                                                                           // BuildMemberListExtension.cs:328
	    public override void Read(Extension e)                                                                                                 // BuildMemberListExtension.cs:329
	    {                                                                                                                                      // BuildMemberListExtension.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Quadrant.Read(e);                                                                                                             // BuildMemberListExtension.cs:398
	        this.Region.Read(e);                                                                                                               // BuildMemberListExtension.cs:398
	        this.ClockDirection.Read(e);                                                                                                       // BuildMemberListExtension.cs:398
	        this.Depth.Read(e);                                                                                                                // BuildMemberListExtension.cs:398
	    }                                                                                                                                      // BuildMemberListExtension.cs:335
	                                                                                                                                           // BuildMemberListExtension.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public override void Write(Extension e)                                                                                                // BuildMemberListExtension.cs:340
	    {                                                                                                                                      // BuildMemberListExtension.cs:341
	        this.Quadrant.Write(e);                                                                                                            // BuildMemberListExtension.cs:401
	        this.Region.Write(e);                                                                                                              // BuildMemberListExtension.cs:401
	        this.ClockDirection.Write(e);                                                                                                      // BuildMemberListExtension.cs:401
	        this.Depth.Write(e);                                                                                                               // BuildMemberListExtension.cs:401
	    }                                                                                                                                      // BuildMemberListExtension.cs:343
	}                                                                                                                                          // BuildMemberListExtension.cs:344
	                                                                                                                                           // BuildMemberListExtension.cs:435
	/// <summary>
	/// Class that implements the QuadrantExtension' extension slice class.
	/// </summary>
	public class QuadrantExtension : MemberListExtensionItem<CodeableConcept>                                                                  // BuildMemberListExtension.cs:439
	{                                                                                                                                          // BuildMemberListExtension.cs:440
	                                                                                                                                           // BuildMemberListExtension.cs:466
	    /// <summary>
	    /// Get value of extension slice quadrant
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:470
	                                                                                                                                           // BuildMemberListExtension.cs:475
	    /// <summary>
	    /// Set value of extension slice quadrant
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:479
	                                                                                                                                           // BuildMemberListExtension.cs:444
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public QuadrantExtension(BreastRadiologyDocument doc) : base("QuadrantExtension")                                                      // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	        this.Init(doc, 0, 1, "quadrant");                                                                                                  // BuildMemberListExtension.cs:450
	    }                                                                                                                                      // BuildMemberListExtension.cs:452
	                                                                                                                                           // BuildMemberListExtension.cs:455
	}                                                                                                                                          // BuildMemberListExtension.cs:456
	                                                                                                                                           // BuildMemberListExtension.cs:435
	/// <summary>
	/// Class that implements the RegionExtension' extension slice class.
	/// </summary>
	public class RegionExtension : MemberListExtensionItem<CodeableConcept>                                                                    // BuildMemberListExtension.cs:439
	{                                                                                                                                          // BuildMemberListExtension.cs:440
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListExtension.cs:507
	                                                                                                                                           // BuildMemberListExtension.cs:509
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListExtension.cs:513
	                                                                                                                                           // BuildMemberListExtension.cs:515
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:520
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListExtension.cs:524
	                                                                                                                                           // BuildMemberListExtension.cs:444
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RegionExtension(BreastRadiologyDocument doc) : base("RegionExtension")                                                          // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	        this.Init(doc, 0, -1, "region");                                                                                                   // BuildMemberListExtension.cs:450
	    }                                                                                                                                      // BuildMemberListExtension.cs:452
	                                                                                                                                           // BuildMemberListExtension.cs:494
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                                // BuildMemberListExtension.cs:498
	                                                                                                                                           // BuildMemberListExtension.cs:494
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendCodeableConcept(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                 // BuildMemberListExtension.cs:498
	                                                                                                                                           // BuildMemberListExtension.cs:455
	}                                                                                                                                          // BuildMemberListExtension.cs:456
	                                                                                                                                           // BuildMemberListExtension.cs:435
	/// <summary>
	/// Class that implements the ClockDirectionExtension' extension slice class.
	/// </summary>
	public class ClockDirectionExtension : MemberListExtensionItem<CodeableConcept>                                                            // BuildMemberListExtension.cs:439
	{                                                                                                                                          // BuildMemberListExtension.cs:440
	                                                                                                                                           // BuildMemberListExtension.cs:466
	    /// <summary>
	    /// Get value of extension slice clockDirection
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:470
	                                                                                                                                           // BuildMemberListExtension.cs:475
	    /// <summary>
	    /// Set value of extension slice clockDirection
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:479
	                                                                                                                                           // BuildMemberListExtension.cs:444
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ClockDirectionExtension(BreastRadiologyDocument doc) : base("ClockDirectionExtension")                                          // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	        this.Init(doc, 0, 1, "clockDirection");                                                                                            // BuildMemberListExtension.cs:450
	    }                                                                                                                                      // BuildMemberListExtension.cs:452
	                                                                                                                                           // BuildMemberListExtension.cs:455
	}                                                                                                                                          // BuildMemberListExtension.cs:456
	                                                                                                                                           // BuildMemberListExtension.cs:435
	/// <summary>
	/// Class that implements the DepthExtension' extension slice class.
	/// </summary>
	public class DepthExtension : MemberListExtensionItem<CodeableConcept>                                                                     // BuildMemberListExtension.cs:439
	{                                                                                                                                          // BuildMemberListExtension.cs:440
	                                                                                                                                           // BuildMemberListExtension.cs:466
	    /// <summary>
	    /// Get value of extension slice depth
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:470
	                                                                                                                                           // BuildMemberListExtension.cs:475
	    /// <summary>
	    /// Set value of extension slice depth
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:479
	                                                                                                                                           // BuildMemberListExtension.cs:444
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DepthExtension(BreastRadiologyDocument doc) : base("DepthExtension")                                                            // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	        this.Init(doc, 0, 1, "depth");                                                                                                     // BuildMemberListExtension.cs:450
	    }                                                                                                                                      // BuildMemberListExtension.cs:452
	                                                                                                                                           // BuildMemberListExtension.cs:455
	}                                                                                                                                          // BuildMemberListExtension.cs:456
	//- LocalClassDefs
}

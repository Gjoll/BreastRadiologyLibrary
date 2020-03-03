using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;
//+Usings
using BreastRadLib.BodyDistanceFromExtensionLocal;
using BreastRadLib.BodyDistanceFromExtensionLocal;
using BreastRadLib.BodyDistanceFromExtensionLocal;
//-Usings

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BreastBodyLocation' extension class.
	/// </summary>
	public class BreastBodyLocationExtension : MemberListExtensionComplex                                                                      // BuildMemberListExtension.cs:319
	{                                                                                                                                          // BuildMemberListExtension.cs:320
	    QuadrantExtension Quadrant;                                                                                                            // BuildMemberListExtension.cs:459
	    RegionExtension Region;                                                                                                                // BuildMemberListExtension.cs:459
	    ClockDirectionExtension ClockDirection;                                                                                                // BuildMemberListExtension.cs:459
	    DepthExtension Depth;                                                                                                                  // BuildMemberListExtension.cs:459
	    BodyDistanceFromExtension DistanceFromNipple;                                                                                          // BuildMemberListExtension.cs:459
	    BodyDistanceFromExtension DistanceFromChestWall;                                                                                       // BuildMemberListExtension.cs:459
	    BodyDistanceFromExtension DistanceFromSkin;                                                                                            // BuildMemberListExtension.cs:459
	                                                                                                                                           // BuildMemberListExtension.cs:322
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension(BreastRadiologyDocument doc) : base("BreastBodyLocation")                                           // BuildMemberListExtension.cs:326
	    {                                                                                                                                      // BuildMemberListExtension.cs:327
	        this.Init(doc, 0, 2147483647);                                                                                                     // BuildMemberListExtension.cs:328
	        this.Quadrant = new QuadrantExtension(this.doc);                                                                                   // BuildMemberListExtension.cs:462
	        this.Region = new RegionExtension(this.doc);                                                                                       // BuildMemberListExtension.cs:462
	        this.ClockDirection = new ClockDirectionExtension(this.doc);                                                                       // BuildMemberListExtension.cs:462
	        this.Depth = new DepthExtension(this.doc);                                                                                         // BuildMemberListExtension.cs:462
	        this.DistanceFromNipple = new BodyDistanceFromExtension(this.doc);                                                                 // BuildMemberListExtension.cs:462
	        this.DistanceFromChestWall = new BodyDistanceFromExtension(this.doc);                                                              // BuildMemberListExtension.cs:462
	        this.DistanceFromSkin = new BodyDistanceFromExtension(this.doc);                                                                   // BuildMemberListExtension.cs:462
	    }                                                                                                                                      // BuildMemberListExtension.cs:330
	                                                                                                                                           // BuildMemberListExtension.cs:331
	    /// <summary>
	    /// Read extension values
	    /// </summary>
	    public override void ReadItems(IEnumerable<Extension> e)                                                                               // BuildMemberListExtension.cs:335
	    {                                                                                                                                      // BuildMemberListExtension.cs:336
	        this.Quadrant.ReadItems(e);                                                                                                        // BuildMemberListExtension.cs:465
	        this.Region.ReadItems(e);                                                                                                          // BuildMemberListExtension.cs:465
	        this.ClockDirection.ReadItems(e);                                                                                                  // BuildMemberListExtension.cs:465
	        this.Depth.ReadItems(e);                                                                                                           // BuildMemberListExtension.cs:465
	        this.DistanceFromNipple.ReadItems(e);                                                                                              // BuildMemberListExtension.cs:465
	        this.DistanceFromChestWall.ReadItems(e);                                                                                           // BuildMemberListExtension.cs:465
	        this.DistanceFromSkin.ReadItems(e);                                                                                                // BuildMemberListExtension.cs:465
	    }                                                                                                                                      // BuildMemberListExtension.cs:338
	                                                                                                                                           // BuildMemberListExtension.cs:339
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public override IEnumerable<Extension> WriteItems()                                                                                    // BuildMemberListExtension.cs:343
	    {                                                                                                                                      // BuildMemberListExtension.cs:344
	        List<Extension> retVal = new List<Extension>();                                                                                    // BuildMemberListExtension.cs:345
	        retVal.AddRange(this.Quadrant.WriteItems());                                                                                       // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.Region.WriteItems());                                                                                         // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.ClockDirection.WriteItems());                                                                                 // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.Depth.WriteItems());                                                                                          // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.DistanceFromNipple.WriteItems());                                                                             // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.DistanceFromChestWall.WriteItems());                                                                          // BuildMemberListExtension.cs:468
	        retVal.AddRange(this.DistanceFromSkin.WriteItems());                                                                               // BuildMemberListExtension.cs:468
	        return retVal.ToArray();                                                                                                           // BuildMemberListExtension.cs:347
	    }                                                                                                                                      // BuildMemberListExtension.cs:348
	}                                                                                                                                          // BuildMemberListExtension.cs:349
	                                                                                                                                           // BuildMemberListExtension.cs:502
	/// <summary>
	/// Class that implements the QuadrantExtension' extension slice class.
	/// </summary>
	public class QuadrantExtension : MemberListExtensionSimple<CodeableConcept>                                                                // BuildMemberListExtension.cs:506
	{                                                                                                                                          // BuildMemberListExtension.cs:507
	                                                                                                                                           // BuildMemberListExtension.cs:533
	    /// <summary>
	    /// Get value of extension slice quadrant
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:537
	                                                                                                                                           // BuildMemberListExtension.cs:542
	    /// <summary>
	    /// Set value of extension slice quadrant
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:546
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public QuadrantExtension(BreastRadiologyDocument doc) : base("QuadrantExtension")                                                      // BuildMemberListExtension.cs:515
	    {                                                                                                                                      // BuildMemberListExtension.cs:516
	        this.Init(doc, 0, 1, "quadrant");                                                                                                  // BuildMemberListExtension.cs:517
	    }                                                                                                                                      // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:522
	}                                                                                                                                          // BuildMemberListExtension.cs:523
	                                                                                                                                           // BuildMemberListExtension.cs:502
	/// <summary>
	/// Class that implements the RegionExtension' extension slice class.
	/// </summary>
	public class RegionExtension : MemberListExtensionSimple<CodeableConcept>                                                                  // BuildMemberListExtension.cs:506
	{                                                                                                                                          // BuildMemberListExtension.cs:507
	    /// <summary>
	    /// Access propertyName
	    /// </summary>
	    public IEnumerable<CodeableConcept> All() => this.items;                                                                               // BuildMemberListExtension.cs:574
	                                                                                                                                           // BuildMemberListExtension.cs:576
	    /// <summary>
	    /// Access item at indicated location in list
	    /// </summary>
	    public CodeableConcept At(Int32 i) => base.items[i];                                                                                   // BuildMemberListExtension.cs:580
	                                                                                                                                           // BuildMemberListExtension.cs:582
	    /// <summary>
	    /// Access first item in list
	    /// </summary>
	    public new CodeableConcept First() => base.First();                                                                                    // BuildMemberListExtension.cs:586
	                                                                                                                                           // BuildMemberListExtension.cs:587
	    /// <summary>
	    /// Access first item in list or default value if empty
	    /// </summary>
	    public new CodeableConcept FirstOrDefault() => base.FirstOrDefault();                                                                  // BuildMemberListExtension.cs:591
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RegionExtension(BreastRadiologyDocument doc) : base("RegionExtension")                                                          // BuildMemberListExtension.cs:515
	    {                                                                                                                                      // BuildMemberListExtension.cs:516
	        this.Init(doc, 0, -1, "region");                                                                                                   // BuildMemberListExtension.cs:517
	    }                                                                                                                                      // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:561
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                                // BuildMemberListExtension.cs:565
	                                                                                                                                           // BuildMemberListExtension.cs:561
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendCodeableConcept(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                 // BuildMemberListExtension.cs:565
	                                                                                                                                           // BuildMemberListExtension.cs:522
	}                                                                                                                                          // BuildMemberListExtension.cs:523
	                                                                                                                                           // BuildMemberListExtension.cs:502
	/// <summary>
	/// Class that implements the ClockDirectionExtension' extension slice class.
	/// </summary>
	public class ClockDirectionExtension : MemberListExtensionSimple<CodeableConcept>                                                          // BuildMemberListExtension.cs:506
	{                                                                                                                                          // BuildMemberListExtension.cs:507
	                                                                                                                                           // BuildMemberListExtension.cs:533
	    /// <summary>
	    /// Get value of extension slice clockDirection
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:537
	                                                                                                                                           // BuildMemberListExtension.cs:542
	    /// <summary>
	    /// Set value of extension slice clockDirection
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:546
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ClockDirectionExtension(BreastRadiologyDocument doc) : base("ClockDirectionExtension")                                          // BuildMemberListExtension.cs:515
	    {                                                                                                                                      // BuildMemberListExtension.cs:516
	        this.Init(doc, 0, 1, "clockDirection");                                                                                            // BuildMemberListExtension.cs:517
	    }                                                                                                                                      // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:522
	}                                                                                                                                          // BuildMemberListExtension.cs:523
	                                                                                                                                           // BuildMemberListExtension.cs:502
	/// <summary>
	/// Class that implements the DepthExtension' extension slice class.
	/// </summary>
	public class DepthExtension : MemberListExtensionSimple<CodeableConcept>                                                                   // BuildMemberListExtension.cs:506
	{                                                                                                                                          // BuildMemberListExtension.cs:507
	                                                                                                                                           // BuildMemberListExtension.cs:533
	    /// <summary>
	    /// Get value of extension slice depth
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:537
	                                                                                                                                           // BuildMemberListExtension.cs:542
	    /// <summary>
	    /// Set value of extension slice depth
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:546
	                                                                                                                                           // BuildMemberListExtension.cs:511
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DepthExtension(BreastRadiologyDocument doc) : base("DepthExtension")                                                            // BuildMemberListExtension.cs:515
	    {                                                                                                                                      // BuildMemberListExtension.cs:516
	        this.Init(doc, 0, 1, "depth");                                                                                                     // BuildMemberListExtension.cs:517
	    }                                                                                                                                      // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:522
	}                                                                                                                                          // BuildMemberListExtension.cs:523
	//- LocalClassDefs
}

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
	public class BreastBodyLocationExtension : MemberListExtension                                                                             // BuildMemberListExtension.cs:317
	{                                                                                                                                          // BuildMemberListExtension.cs:318
	    QuadrantExtensionItem Quadrant;                                                                                                        // BuildMemberListExtension.cs:392
	    RegionExtensionItem Region;                                                                                                            // BuildMemberListExtension.cs:392
	    ClockDirectionExtensionItem ClockDirection;                                                                                            // BuildMemberListExtension.cs:392
	    DepthExtensionItem Depth;                                                                                                              // BuildMemberListExtension.cs:392
	                                                                                                                                           // BuildMemberListExtension.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension() : base("BreastBodyLocation")                                                                      // BuildMemberListExtension.cs:324
	    {                                                                                                                                      // BuildMemberListExtension.cs:325
	        this.Quadrant = new QuadrantExtensionItem(this.doc);                                                                               // BuildMemberListExtension.cs:395
	        this.Region = new RegionExtensionItem(this.doc);                                                                                   // BuildMemberListExtension.cs:395
	        this.ClockDirection = new ClockDirectionExtensionItem(this.doc);                                                                   // BuildMemberListExtension.cs:395
	        this.Depth = new DepthExtensionItem(this.doc);                                                                                     // BuildMemberListExtension.cs:395
	    }                                                                                                                                      // BuildMemberListExtension.cs:327
	                                                                                                                                           // BuildMemberListExtension.cs:328
	    public void Read()                                                                                                                     // BuildMemberListExtension.cs:329
	    {                                                                                                                                      // BuildMemberListExtension.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Read(this.Quadrant);                                                                                                          // BuildMemberListExtension.cs:398
	        this.Read(this.Region);                                                                                                            // BuildMemberListExtension.cs:398
	        this.Read(this.ClockDirection);                                                                                                    // BuildMemberListExtension.cs:398
	        this.Read(this.Depth);                                                                                                             // BuildMemberListExtension.cs:398
	    }                                                                                                                                      // BuildMemberListExtension.cs:335
	                                                                                                                                           // BuildMemberListExtension.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public void Write()                                                                                                                    // BuildMemberListExtension.cs:340
	    {                                                                                                                                      // BuildMemberListExtension.cs:341
	        this.Write(this.Quadrant);                                                                                                         // BuildMemberListExtension.cs:401
	        this.Write(this.Region);                                                                                                           // BuildMemberListExtension.cs:401
	        this.Write(this.ClockDirection);                                                                                                   // BuildMemberListExtension.cs:401
	        this.Write(this.Depth);                                                                                                            // BuildMemberListExtension.cs:401
	    }                                                                                                                                      // BuildMemberListExtension.cs:343
	}                                                                                                                                          // BuildMemberListExtension.cs:344
	                                                                                                                                           // BuildMemberListExtension.cs:422
	/// <summary>
	/// Class that implements the QuadrantExtensionItem' extension slice class.
	/// </summary>
	public class QuadrantExtensionItem : MemberListExtension                                                                                   // BuildMemberListExtension.cs:426
	{                                                                                                                                          // BuildMemberListExtension.cs:427
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Get value of extension slice quadrant
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:486
	    /// <summary>
	    /// Set value of extension slice quadrant
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:490
	                                                                                                                                           // BuildMemberListExtension.cs:431
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public QuadrantExtensionItem(BreastRadiologyDocument doc) : base("QuadrantExtensionItem")                                              // BuildMemberListExtension.cs:435
	    {                                                                                                                                      // BuildMemberListExtension.cs:436
	        this.Init(doc, 0, 1, "quadrant");                                                                                                  // BuildMemberListExtension.cs:437
	    }                                                                                                                                      // BuildMemberListExtension.cs:439
	                                                                                                                                           // BuildMemberListExtension.cs:441
	    public void Read()                                                                                                                     // BuildMemberListExtension.cs:442
	    {                                                                                                                                      // BuildMemberListExtension.cs:443
	    }                                                                                                                                      // BuildMemberListExtension.cs:445
	                                                                                                                                           // BuildMemberListExtension.cs:447
	    public void Write()                                                                                                                    // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	    }                                                                                                                                      // BuildMemberListExtension.cs:451
	                                                                                                                                           // BuildMemberListExtension.cs:453
	}                                                                                                                                          // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:422
	/// <summary>
	/// Class that implements the RegionExtensionItem' extension slice class.
	/// </summary>
	public class RegionExtensionItem : MemberListExtension                                                                                     // BuildMemberListExtension.cs:426
	{                                                                                                                                          // BuildMemberListExtension.cs:427
	                                                                                                                                           // BuildMemberListExtension.cs:515
	    /// <summary>
	    /// Get value of extension slice region
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:519
	                                                                                                                                           // BuildMemberListExtension.cs:431
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public RegionExtensionItem(BreastRadiologyDocument doc) : base("RegionExtensionItem")                                                  // BuildMemberListExtension.cs:435
	    {                                                                                                                                      // BuildMemberListExtension.cs:436
	        this.Init(doc, 0, -1, "region");                                                                                                   // BuildMemberListExtension.cs:437
	    }                                                                                                                                      // BuildMemberListExtension.cs:439
	                                                                                                                                           // BuildMemberListExtension.cs:441
	    public void Read()                                                                                                                     // BuildMemberListExtension.cs:442
	    {                                                                                                                                      // BuildMemberListExtension.cs:443
	    }                                                                                                                                      // BuildMemberListExtension.cs:445
	                                                                                                                                           // BuildMemberListExtension.cs:447
	    public void Write()                                                                                                                    // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	    }                                                                                                                                      // BuildMemberListExtension.cs:451
	                                                                                                                                           // BuildMemberListExtension.cs:505
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void Append(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                                // BuildMemberListExtension.cs:509
	                                                                                                                                           // BuildMemberListExtension.cs:505
	    /// <summary>
	    /// Append item to end of list
	    /// </summary>
	    public void AppendCodeableConcept(BreastLocationRegionVS.TCoding value) => this.RawItems.Add((CodeableConcept) value);                 // BuildMemberListExtension.cs:509
	                                                                                                                                           // BuildMemberListExtension.cs:453
	}                                                                                                                                          // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:422
	/// <summary>
	/// Class that implements the ClockDirectionExtensionItem' extension slice class.
	/// </summary>
	public class ClockDirectionExtensionItem : MemberListExtension                                                                             // BuildMemberListExtension.cs:426
	{                                                                                                                                          // BuildMemberListExtension.cs:427
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Get value of extension slice clockDirection
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:486
	    /// <summary>
	    /// Set value of extension slice clockDirection
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:490
	                                                                                                                                           // BuildMemberListExtension.cs:431
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ClockDirectionExtensionItem(BreastRadiologyDocument doc) : base("ClockDirectionExtensionItem")                                  // BuildMemberListExtension.cs:435
	    {                                                                                                                                      // BuildMemberListExtension.cs:436
	        this.Init(doc, 0, 1, "clockDirection");                                                                                            // BuildMemberListExtension.cs:437
	    }                                                                                                                                      // BuildMemberListExtension.cs:439
	                                                                                                                                           // BuildMemberListExtension.cs:441
	    public void Read()                                                                                                                     // BuildMemberListExtension.cs:442
	    {                                                                                                                                      // BuildMemberListExtension.cs:443
	    }                                                                                                                                      // BuildMemberListExtension.cs:445
	                                                                                                                                           // BuildMemberListExtension.cs:447
	    public void Write()                                                                                                                    // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	    }                                                                                                                                      // BuildMemberListExtension.cs:451
	                                                                                                                                           // BuildMemberListExtension.cs:453
	}                                                                                                                                          // BuildMemberListExtension.cs:454
	                                                                                                                                           // BuildMemberListExtension.cs:422
	/// <summary>
	/// Class that implements the DepthExtensionItem' extension slice class.
	/// </summary>
	public class DepthExtensionItem : MemberListExtension                                                                                      // BuildMemberListExtension.cs:426
	{                                                                                                                                          // BuildMemberListExtension.cs:427
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Get value of extension slice depth
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:486
	    /// <summary>
	    /// Set value of extension slice depth
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:490
	                                                                                                                                           // BuildMemberListExtension.cs:431
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DepthExtensionItem(BreastRadiologyDocument doc) : base("DepthExtensionItem")                                                    // BuildMemberListExtension.cs:435
	    {                                                                                                                                      // BuildMemberListExtension.cs:436
	        this.Init(doc, 0, 1, "depth");                                                                                                     // BuildMemberListExtension.cs:437
	    }                                                                                                                                      // BuildMemberListExtension.cs:439
	                                                                                                                                           // BuildMemberListExtension.cs:441
	    public void Read()                                                                                                                     // BuildMemberListExtension.cs:442
	    {                                                                                                                                      // BuildMemberListExtension.cs:443
	    }                                                                                                                                      // BuildMemberListExtension.cs:445
	                                                                                                                                           // BuildMemberListExtension.cs:447
	    public void Write()                                                                                                                    // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	    }                                                                                                                                      // BuildMemberListExtension.cs:451
	                                                                                                                                           // BuildMemberListExtension.cs:453
	}                                                                                                                                          // BuildMemberListExtension.cs:454
	//- LocalClassDefs
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BodyDistanceFrom' extension class.
	/// </summary>
	public class BodyDistanceFromExtension : MemberListExtension                                                                               // BuildMemberListExtension.cs:317
	{                                                                                                                                          // BuildMemberListExtension.cs:318
	    LandMarkExtensionItem LandMark;                                                                                                        // BuildMemberListExtension.cs:392
	    DistanceFromLandMarkExtensionItem DistanceFromLandMark;                                                                                // BuildMemberListExtension.cs:392
	                                                                                                                                           // BuildMemberListExtension.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension() : base("BodyDistanceFrom")                                                                          // BuildMemberListExtension.cs:324
	    {                                                                                                                                      // BuildMemberListExtension.cs:325
	        this.LandMark = new LandMarkExtensionItem(this.doc);                                                                               // BuildMemberListExtension.cs:395
	        this.DistanceFromLandMark = new DistanceFromLandMarkExtensionItem(this.doc);                                                       // BuildMemberListExtension.cs:395
	    }                                                                                                                                      // BuildMemberListExtension.cs:327
	                                                                                                                                           // BuildMemberListExtension.cs:328
	    public void Read()                                                                                                                     // BuildMemberListExtension.cs:329
	    {                                                                                                                                      // BuildMemberListExtension.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.Read(this.LandMark);                                                                                                          // BuildMemberListExtension.cs:398
	        this.Read(this.DistanceFromLandMark);                                                                                              // BuildMemberListExtension.cs:398
	    }                                                                                                                                      // BuildMemberListExtension.cs:335
	                                                                                                                                           // BuildMemberListExtension.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public void Write()                                                                                                                    // BuildMemberListExtension.cs:340
	    {                                                                                                                                      // BuildMemberListExtension.cs:341
	        this.Write(this.LandMark);                                                                                                         // BuildMemberListExtension.cs:401
	        this.Write(this.DistanceFromLandMark);                                                                                             // BuildMemberListExtension.cs:401
	    }                                                                                                                                      // BuildMemberListExtension.cs:343
	}                                                                                                                                          // BuildMemberListExtension.cs:344
	                                                                                                                                           // BuildMemberListExtension.cs:422
	/// <summary>
	/// Class that implements the LandMarkExtensionItem' extension slice class.
	/// </summary>
	public class LandMarkExtensionItem : MemberListExtension                                                                                   // BuildMemberListExtension.cs:426
	{                                                                                                                                          // BuildMemberListExtension.cs:427
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Get value of extension slice landMark
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:486
	    /// <summary>
	    /// Set value of extension slice landMark
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:490
	                                                                                                                                           // BuildMemberListExtension.cs:431
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public LandMarkExtensionItem(BreastRadiologyDocument doc) : base("LandMarkExtensionItem")                                              // BuildMemberListExtension.cs:435
	    {                                                                                                                                      // BuildMemberListExtension.cs:436
	        this.Init(doc, 0, 1, "landMark");                                                                                                  // BuildMemberListExtension.cs:437
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
	/// Class that implements the DistanceFromLandMarkExtensionItem' extension slice class.
	/// </summary>
	public class DistanceFromLandMarkExtensionItem : MemberListExtension                                                                       // BuildMemberListExtension.cs:426
	{                                                                                                                                          // BuildMemberListExtension.cs:427
	                                                                                                                                           // BuildMemberListExtension.cs:477
	    /// <summary>
	    /// Get value of extension slice distanceFromLandMark
	    /// </summary>
	    public Quantity Get() => (Quantity) this.First();                                                                                      // BuildMemberListExtension.cs:481
	                                                                                                                                           // BuildMemberListExtension.cs:486
	    /// <summary>
	    /// Set value of extension slice distanceFromLandMark
	    /// </summary>
	    public void Set(Quantity value) => this.SetSingleItem(value);                                                                          // BuildMemberListExtension.cs:490
	                                                                                                                                           // BuildMemberListExtension.cs:431
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DistanceFromLandMarkExtensionItem(BreastRadiologyDocument doc) : base("DistanceFromLandMarkExtensionItem")                      // BuildMemberListExtension.cs:435
	    {                                                                                                                                      // BuildMemberListExtension.cs:436
	        this.Init(doc, 0, 1, "distanceFromLandMark");                                                                                      // BuildMemberListExtension.cs:437
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

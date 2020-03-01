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
	public class BodyDistanceFromExtension : MemberListExtension<IMemberListExtension>                                                         // BuildMemberListExtension.cs:317
	{                                                                                                                                          // BuildMemberListExtension.cs:318
	    LandMarkExtension LandMark;                                                                                                            // BuildMemberListExtension.cs:392
	    DistanceFromLandMarkExtension DistanceFromLandMark;                                                                                    // BuildMemberListExtension.cs:392
	                                                                                                                                           // BuildMemberListExtension.cs:320
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension() : base("BodyDistanceFrom")                                                                          // BuildMemberListExtension.cs:324
	    {                                                                                                                                      // BuildMemberListExtension.cs:325
	        this.LandMark = new LandMarkExtension(this.doc);                                                                                   // BuildMemberListExtension.cs:395
	        this.DistanceFromLandMark = new DistanceFromLandMarkExtension(this.doc);                                                           // BuildMemberListExtension.cs:395
	    }                                                                                                                                      // BuildMemberListExtension.cs:327
	                                                                                                                                           // BuildMemberListExtension.cs:328
	    public override void Read(Extension e)                                                                                                 // BuildMemberListExtension.cs:329
	    {                                                                                                                                      // BuildMemberListExtension.cs:330
	        /// <summary>
	        /// Read extension values
	        /// </summary>
	        this.LandMark.Read(e);                                                                                                             // BuildMemberListExtension.cs:398
	        this.DistanceFromLandMark.Read(e);                                                                                                 // BuildMemberListExtension.cs:398
	    }                                                                                                                                      // BuildMemberListExtension.cs:335
	                                                                                                                                           // BuildMemberListExtension.cs:336
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public override void Write(Extension e)                                                                                                // BuildMemberListExtension.cs:340
	    {                                                                                                                                      // BuildMemberListExtension.cs:341
	        this.LandMark.Write(e);                                                                                                            // BuildMemberListExtension.cs:401
	        this.DistanceFromLandMark.Write(e);                                                                                                // BuildMemberListExtension.cs:401
	    }                                                                                                                                      // BuildMemberListExtension.cs:343
	}                                                                                                                                          // BuildMemberListExtension.cs:344
	                                                                                                                                           // BuildMemberListExtension.cs:435
	/// <summary>
	/// Class that implements the LandMarkExtension' extension slice class.
	/// </summary>
	public class LandMarkExtension : MemberListExtensionItem<CodeableConcept>                                                                  // BuildMemberListExtension.cs:439
	{                                                                                                                                          // BuildMemberListExtension.cs:440
	                                                                                                                                           // BuildMemberListExtension.cs:466
	    /// <summary>
	    /// Get value of extension slice landMark
	    /// </summary>
	    public CodeableConcept Get() => (CodeableConcept) this.First();                                                                        // BuildMemberListExtension.cs:470
	                                                                                                                                           // BuildMemberListExtension.cs:475
	    /// <summary>
	    /// Set value of extension slice landMark
	    /// </summary>
	    public void Set(CodeableConcept value) => this.SetSingleItem(value);                                                                   // BuildMemberListExtension.cs:479
	                                                                                                                                           // BuildMemberListExtension.cs:444
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public LandMarkExtension(BreastRadiologyDocument doc) : base("LandMarkExtension")                                                      // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	        this.Init(doc, 0, 1, "landMark");                                                                                                  // BuildMemberListExtension.cs:450
	    }                                                                                                                                      // BuildMemberListExtension.cs:452
	                                                                                                                                           // BuildMemberListExtension.cs:455
	}                                                                                                                                          // BuildMemberListExtension.cs:456
	                                                                                                                                           // BuildMemberListExtension.cs:435
	/// <summary>
	/// Class that implements the DistanceFromLandMarkExtension' extension slice class.
	/// </summary>
	public class DistanceFromLandMarkExtension : MemberListExtensionItem<Quantity>                                                             // BuildMemberListExtension.cs:439
	{                                                                                                                                          // BuildMemberListExtension.cs:440
	                                                                                                                                           // BuildMemberListExtension.cs:466
	    /// <summary>
	    /// Get value of extension slice distanceFromLandMark
	    /// </summary>
	    public Quantity Get() => (Quantity) this.First();                                                                                      // BuildMemberListExtension.cs:470
	                                                                                                                                           // BuildMemberListExtension.cs:475
	    /// <summary>
	    /// Set value of extension slice distanceFromLandMark
	    /// </summary>
	    public void Set(Quantity value) => this.SetSingleItem(value);                                                                          // BuildMemberListExtension.cs:479
	                                                                                                                                           // BuildMemberListExtension.cs:444
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public DistanceFromLandMarkExtension(BreastRadiologyDocument doc) : base("DistanceFromLandMarkExtension")                              // BuildMemberListExtension.cs:448
	    {                                                                                                                                      // BuildMemberListExtension.cs:449
	        this.Init(doc, 0, 1, "distanceFromLandMark");                                                                                      // BuildMemberListExtension.cs:450
	    }                                                                                                                                      // BuildMemberListExtension.cs:452
	                                                                                                                                           // BuildMemberListExtension.cs:455
	}                                                                                                                                          // BuildMemberListExtension.cs:456
	//- LocalClassDefs
}

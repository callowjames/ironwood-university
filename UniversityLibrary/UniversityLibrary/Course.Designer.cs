﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("IronwoodModel", "FK_UniversityCourse_DepartmentID", "UniversityDepartment", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(UniversityLibrary.Department), "UniversityCourse", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(UniversityLibrary.Course), true)]

#endregion

namespace UniversityLibrary
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class IronwoodEntities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new IronwoodEntities2 object using the connection string found in the 'IronwoodEntities2' section of the application configuration file.
        /// </summary>
        public IronwoodEntities2() : base("name=IronwoodEntities2", "IronwoodEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new IronwoodEntities2 object.
        /// </summary>
        public IronwoodEntities2(string connectionString) : base(connectionString, "IronwoodEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new IronwoodEntities2 object.
        /// </summary>
        public IronwoodEntities2(EntityConnection connection) : base(connection, "IronwoodEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Course> Courses
        {
            get
            {
                if ((_Courses == null))
                {
                    _Courses = base.CreateObjectSet<Course>("Courses");
                }
                return _Courses;
            }
        }
        private ObjectSet<Course> _Courses;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Department> Departments
        {
            get
            {
                if ((_Departments == null))
                {
                    _Departments = base.CreateObjectSet<Department>("Departments");
                }
                return _Departments;
            }
        }
        private ObjectSet<Department> _Departments;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Courses EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCourses(Course course)
        {
            base.AddObject("Courses", course);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Departments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDepartments(Department department)
        {
            base.AddObject("Departments", department);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IronwoodModel", Name="Course")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Course : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Course object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="credits">Initial value of the Credits property.</param>
        /// <param name="department">Initial value of the Department property.</param>
        public static Course CreateCourse(global::System.Int64 id, global::System.String name, global::System.String title, global::System.Byte credits, global::System.Int64 department)
        {
            Course course = new Course();
            course.ID = id;
            course.Name = name;
            course.Title = title;
            course.Credits = credits;
            course.Department = department;
            return course;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Credits
        {
            get
            {
                return _Credits;
            }
            set
            {
                OnCreditsChanging(value);
                ReportPropertyChanging("Credits");
                _Credits = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Credits");
                OnCreditsChanged();
            }
        }
        private global::System.Byte _Credits;
        partial void OnCreditsChanging(global::System.Byte value);
        partial void OnCreditsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Department
        {
            get
            {
                return _Department;
            }
            set
            {
                OnDepartmentChanging(value);
                ReportPropertyChanging("Department");
                _Department = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Department");
                OnDepartmentChanged();
            }
        }
        private global::System.Int64 _Department;
        partial void OnDepartmentChanging(global::System.Int64 value);
        partial void OnDepartmentChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("IronwoodModel", "FK_UniversityCourse_DepartmentID", "UniversityDepartment")]
        public Department UniversityDepartment
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("IronwoodModel.FK_UniversityCourse_DepartmentID", "UniversityDepartment").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("IronwoodModel.FK_UniversityCourse_DepartmentID", "UniversityDepartment").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Department> UniversityDepartmentReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Department>("IronwoodModel.FK_UniversityCourse_DepartmentID", "UniversityDepartment");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Department>("IronwoodModel.FK_UniversityCourse_DepartmentID", "UniversityDepartment", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="IronwoodModel", Name="Department")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Department : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Department object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="chair">Initial value of the Chair property.</param>
        public static Department CreateDepartment(global::System.Int64 id, global::System.String name, global::System.Int64 chair)
        {
            Department department = new Department();
            department.ID = id;
            department.Name = name;
            department.Chair = chair;
            return department;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Office
        {
            get
            {
                return _Office;
            }
            set
            {
                OnOfficeChanging(value);
                ReportPropertyChanging("Office");
                _Office = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Office");
                OnOfficeChanged();
            }
        }
        private global::System.String _Office;
        partial void OnOfficeChanging(global::System.String value);
        partial void OnOfficeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Chair
        {
            get
            {
                return _Chair;
            }
            set
            {
                OnChairChanging(value);
                ReportPropertyChanging("Chair");
                _Chair = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Chair");
                OnChairChanged();
            }
        }
        private global::System.Int64 _Chair;
        partial void OnChairChanging(global::System.Int64 value);
        partial void OnChairChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("IronwoodModel", "FK_UniversityCourse_DepartmentID", "UniversityCourse")]
        public EntityCollection<Course> UniversityCourses
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Course>("IronwoodModel.FK_UniversityCourse_DepartmentID", "UniversityCourse");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Course>("IronwoodModel.FK_UniversityCourse_DepartmentID", "UniversityCourse", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
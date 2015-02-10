﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5466
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinic.Models
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/Clinic.Models")]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private Clinic.Models.Admin[] AdminsField;

        private Clinic.Models.Doctor[] DoctorsField;

        private System.Guid IdField;

        private string PasswordField;

        private string RoleField;

        private Clinic.Models.Secretary[] SecretariesField;

        private string UsernameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Admin[] Admins
        {
            get
            {
                return this.AdminsField;
            }
            set
            {
                this.AdminsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Doctor[] Doctors
        {
            get
            {
                return this.DoctorsField;
            }
            set
            {
                this.DoctorsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Role
        {
            get
            {
                return this.RoleField;
            }
            set
            {
                this.RoleField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Secretary[] Secretaries
        {
            get
            {
                return this.SecretariesField;
            }
            set
            {
                this.SecretariesField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Admin", Namespace = "http://schemas.datacontract.org/2004/07/Clinic.Models")]
    public partial class Admin : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Guid IdField;

        private string NameField;

        private Clinic.Models.User UserField;

        private System.Guid UserIdField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.User User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Doctor", Namespace = "http://schemas.datacontract.org/2004/07/Clinic.Models")]
    public partial class Doctor : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private Clinic.Models.Consultation[] ConsultationsField;

        private System.Guid IdField;

        private string NameField;

        private Clinic.Models.User UserField;

        private System.Guid UserIdField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Consultation[] Consultations
        {
            get
            {
                return this.ConsultationsField;
            }
            set
            {
                this.ConsultationsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.User User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Secretary", Namespace = "http://schemas.datacontract.org/2004/07/Clinic.Models")]
    public partial class Secretary : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Guid IdField;

        private string NameField;

        private Clinic.Models.User UserField;

        private System.Guid UserIdField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.User User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId
        {
            get
            {
                return this.UserIdField;
            }
            set
            {
                this.UserIdField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Consultation", Namespace = "http://schemas.datacontract.org/2004/07/Clinic.Models")]
    public partial class Consultation : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private System.Nullable<System.DateTime> DateField;

        private Clinic.Models.Doctor DoctorField;

        private System.Guid DoctorIdField;

        private System.Nullable<System.TimeSpan> HourField;

        private System.Guid IdField;

        private Clinic.Models.Patient PatientField;

        private System.Guid PatientIdField;

        private string ResultField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Doctor Doctor
        {
            get
            {
                return this.DoctorField;
            }
            set
            {
                this.DoctorField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid DoctorId
        {
            get
            {
                return this.DoctorIdField;
            }
            set
            {
                this.DoctorIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.TimeSpan> Hour
        {
            get
            {
                return this.HourField;
            }
            set
            {
                this.HourField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Patient Patient
        {
            get
            {
                return this.PatientField;
            }
            set
            {
                this.PatientField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid PatientId
        {
            get
            {
                return this.PatientIdField;
            }
            set
            {
                this.PatientIdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "Patient", Namespace = "http://schemas.datacontract.org/2004/07/Clinic.Models")]
    public partial class Patient : object, System.Runtime.Serialization.IExtensibleDataObject
    {

        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        private string AddressField;

        private System.Nullable<System.DateTime> BirthDateField;

        private string CNPField;

        private Clinic.Models.Consultation[] ConsultationsField;

        private System.Guid IdField;

        private string IdentityCardNoField;

        private string NameField;

        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address
        {
            get
            {
                return this.AddressField;
            }
            set
            {
                this.AddressField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> BirthDate
        {
            get
            {
                return this.BirthDateField;
            }
            set
            {
                this.BirthDateField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CNP
        {
            get
            {
                return this.CNPField;
            }
            set
            {
                this.CNPField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public Clinic.Models.Consultation[] Consultations
        {
            get
            {
                return this.ConsultationsField;
            }
            set
            {
                this.ConsultationsField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdentityCardNo
        {
            get
            {
                return this.IdentityCardNoField;
            }
            set
            {
                this.IdentityCardNoField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IService1")]
public interface IService1
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/UpdateUser", ReplyAction = "http://tempuri.org/IService1/UpdateUserResponse")]
    void UpdateUser(Clinic.Models.User user);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeleteUser", ReplyAction = "http://tempuri.org/IService1/DeleteUserResponse")]
    void DeleteUser(System.Guid userId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetAllUsers", ReplyAction = "http://tempuri.org/IService1/GetAllUsersResponse")]
    Clinic.Models.User[] GetAllUsers();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetUserById", ReplyAction = "http://tempuri.org/IService1/GetUserByIdResponse")]
    Clinic.Models.User GetUserById(System.Guid userId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetUserByName", ReplyAction = "http://tempuri.org/IService1/GetUserByNameResponse")]
    Clinic.Models.User GetUserByName(string userName);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/checkLogedInUser", ReplyAction = "http://tempuri.org/IService1/checkLogedInUserResponse")]
    string checkLogedInUser(string username, string password);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/AddConsultation", ReplyAction = "http://tempuri.org/IService1/AddConsultationResponse")]
    void AddConsultation(Clinic.Models.Consultation consultation);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/UpdateConsultation", ReplyAction = "http://tempuri.org/IService1/UpdateConsultationResponse")]
    void UpdateConsultation(Clinic.Models.Consultation consultation);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeleteConsultation", ReplyAction = "http://tempuri.org/IService1/DeleteConsultationResponse")]
    void DeleteConsultation(System.Guid consultationId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetAllConsultations", ReplyAction = "http://tempuri.org/IService1/GetAllConsultationsResponse")]
    Clinic.Models.Consultation[] GetAllConsultations();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/getConsultationById", ReplyAction = "http://tempuri.org/IService1/getConsultationByIdResponse")]
    Clinic.Models.Consultation getConsultationById(System.Guid consultationId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetConsultationsByPatientId", ReplyAction = "http://tempuri.org/IService1/GetConsultationsByPatientIdResponse")]
    Clinic.Models.Consultation[] GetConsultationsByPatientId(System.Guid patientId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetConsultationsByDoctorId", ReplyAction = "http://tempuri.org/IService1/GetConsultationsByDoctorIdResponse")]
    Clinic.Models.Consultation[] GetConsultationsByDoctorId(System.Guid doctorId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/AddPatient", ReplyAction = "http://tempuri.org/IService1/AddPatientResponse")]
    void AddPatient(Clinic.Models.Patient patient);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/UpdatePatient", ReplyAction = "http://tempuri.org/IService1/UpdatePatientResponse")]
    void UpdatePatient(Clinic.Models.Patient patient);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeletePatient", ReplyAction = "http://tempuri.org/IService1/DeletePatientResponse")]
    void DeletePatient(System.Guid patientId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetPatientById", ReplyAction = "http://tempuri.org/IService1/GetPatientByIdResponse")]
    Clinic.Models.Patient GetPatientById(System.Guid id);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetAllPatients", ReplyAction = "http://tempuri.org/IService1/GetAllPatientsResponse")]
    Clinic.Models.Patient[] GetAllPatients();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/AddDoctor", ReplyAction = "http://tempuri.org/IService1/AddDoctorResponse")]
    void AddDoctor(Clinic.Models.Doctor doctor);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/UpdateDoctor", ReplyAction = "http://tempuri.org/IService1/UpdateDoctorResponse")]
    void UpdateDoctor(Clinic.Models.Doctor doctor);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeleteDoctor", ReplyAction = "http://tempuri.org/IService1/DeleteDoctorResponse")]
    void DeleteDoctor(System.Guid doctorId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetAllDoctors", ReplyAction = "http://tempuri.org/IService1/GetAllDoctorsResponse")]
    Clinic.Models.Doctor[] GetAllDoctors();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetDoctorById", ReplyAction = "http://tempuri.org/IService1/GetDoctorByIdResponse")]
    Clinic.Models.Doctor GetDoctorById(System.Guid doctorId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetDoctorByUserId", ReplyAction = "http://tempuri.org/IService1/GetDoctorByUserIdResponse")]
    Clinic.Models.Doctor GetDoctorByUserId(System.Guid userId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/AddSecretary", ReplyAction = "http://tempuri.org/IService1/AddSecretaryResponse")]
    void AddSecretary(Clinic.Models.Secretary secretary);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/UpdateSecretary", ReplyAction = "http://tempuri.org/IService1/UpdateSecretaryResponse")]
    void UpdateSecretary(Clinic.Models.Secretary secretary);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/DeleteSecretary", ReplyAction = "http://tempuri.org/IService1/DeleteSecretaryResponse")]
    void DeleteSecretary(System.Guid secretaryId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetAllSecretaries", ReplyAction = "http://tempuri.org/IService1/GetAllSecretariesResponse")]
    Clinic.Models.Secretary[] GetAllSecretaries();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetSecretaryById", ReplyAction = "http://tempuri.org/IService1/GetSecretaryByIdResponse")]
    Clinic.Models.Secretary GetSecretaryById(System.Guid secretaryId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/GetSecretaryByUserId", ReplyAction = "http://tempuri.org/IService1/GetSecretaryByUserIdResponse")]
    Clinic.Models.Secretary GetSecretaryByUserId(System.Guid userId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IService1/AddUser", ReplyAction = "http://tempuri.org/IService1/AddUserResponse")]
    void AddUser(Clinic.Models.User user);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IService1Channel : IService1, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class Service1Client : System.ServiceModel.ClientBase<IService1>, IService1
{

    public Service1Client()
    {
    }

    public Service1Client(string endpointConfigurationName) :
        base(endpointConfigurationName)
    {
    }

    public Service1Client(string endpointConfigurationName, string remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(endpointConfigurationName, remoteAddress)
    {
    }

    public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
    {
    }

    public void UpdateUser(Clinic.Models.User user)
    {
        base.Channel.UpdateUser(user);
    }

    public void DeleteUser(System.Guid userId)
    {
        base.Channel.DeleteUser(userId);
    }

    public Clinic.Models.User[] GetAllUsers()
    {
        return base.Channel.GetAllUsers();
    }

    public Clinic.Models.User GetUserById(System.Guid userId)
    {
        return base.Channel.GetUserById(userId);
    }

    public Clinic.Models.User GetUserByName(string userName)
    {
        return base.Channel.GetUserByName(userName);
    }

    public string checkLogedInUser(string username, string password)
    {
        return base.Channel.checkLogedInUser(username, password);
    }

    public void AddConsultation(Clinic.Models.Consultation consultation)
    {
        base.Channel.AddConsultation(consultation);
    }

    public void UpdateConsultation(Clinic.Models.Consultation consultation)
    {
        base.Channel.UpdateConsultation(consultation);
    }

    public void DeleteConsultation(System.Guid consultationId)
    {
        base.Channel.DeleteConsultation(consultationId);
    }

    public Clinic.Models.Consultation[] GetAllConsultations()
    {
        return base.Channel.GetAllConsultations();
    }

    public Clinic.Models.Consultation getConsultationById(System.Guid consultationId)
    {
        return base.Channel.getConsultationById(consultationId);
    }

    public Clinic.Models.Consultation[] GetConsultationsByPatientId(System.Guid patientId)
    {
        return base.Channel.GetConsultationsByPatientId(patientId);
    }

    public Clinic.Models.Consultation[] GetConsultationsByDoctorId(System.Guid doctorId)
    {
        return base.Channel.GetConsultationsByDoctorId(doctorId);
    }

    public void AddPatient(Clinic.Models.Patient patient)
    {
        base.Channel.AddPatient(patient);
    }

    public void UpdatePatient(Clinic.Models.Patient patient)
    {
        base.Channel.UpdatePatient(patient);
    }

    public void DeletePatient(System.Guid patientId)
    {
        base.Channel.DeletePatient(patientId);
    }

    public Clinic.Models.Patient GetPatientById(System.Guid id)
    {
        return base.Channel.GetPatientById(id);
    }

    public Clinic.Models.Patient[] GetAllPatients()
    {
        return base.Channel.GetAllPatients();
    }

    public void AddDoctor(Clinic.Models.Doctor doctor)
    {
        base.Channel.AddDoctor(doctor);
    }

    public void UpdateDoctor(Clinic.Models.Doctor doctor)
    {
        base.Channel.UpdateDoctor(doctor);
    }

    public void DeleteDoctor(System.Guid doctorId)
    {
        base.Channel.DeleteDoctor(doctorId);
    }

    public Clinic.Models.Doctor[] GetAllDoctors()
    {
        return base.Channel.GetAllDoctors();
    }

    public Clinic.Models.Doctor GetDoctorById(System.Guid doctorId)
    {
        return base.Channel.GetDoctorById(doctorId);
    }

    public Clinic.Models.Doctor GetDoctorByUserId(System.Guid userId)
    {
        return base.Channel.GetDoctorByUserId(userId);
    }

    public void AddSecretary(Clinic.Models.Secretary secretary)
    {
        base.Channel.AddSecretary(secretary);
    }

    public void UpdateSecretary(Clinic.Models.Secretary secretary)
    {
        base.Channel.UpdateSecretary(secretary);
    }

    public void DeleteSecretary(System.Guid secretaryId)
    {
        base.Channel.DeleteSecretary(secretaryId);
    }

    public Clinic.Models.Secretary[] GetAllSecretaries()
    {
        return base.Channel.GetAllSecretaries();
    }

    public Clinic.Models.Secretary GetSecretaryById(System.Guid secretaryId)
    {
        return base.Channel.GetSecretaryById(secretaryId);
    }

    public Clinic.Models.Secretary GetSecretaryByUserId(System.Guid userId)
    {
        return base.Channel.GetSecretaryByUserId(userId);
    }

    public void AddUser(Clinic.Models.User user)
    {
        base.Channel.AddUser(user);
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IMessage", CallbackContract = typeof(IMessageCallback))]
public interface IMessage
{

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessage/AddMessage", ReplyAction = "http://tempuri.org/IMessage/AddMessageResponse")]
    void AddMessage(System.Guid doctorId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessage/Subscribe", ReplyAction = "http://tempuri.org/IMessage/SubscribeResponse")]
    bool Subscribe();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMessage/Unsubscribe", ReplyAction = "http://tempuri.org/IMessage/UnsubscribeResponse")]
    bool Unsubscribe();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IMessageCallback
{

    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IMessage/OnMessageAdded")]
    void OnMessageAdded(System.Guid doctorId);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IMessageChannel : IMessage, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class MessageClient : System.ServiceModel.DuplexClientBase<IMessage>, IMessage
{

    public MessageClient(System.ServiceModel.InstanceContext callbackInstance) :
        base(callbackInstance)
    {
    }

    public MessageClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
        base(callbackInstance, endpointConfigurationName)
    {
    }

    public MessageClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
        base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }

    public MessageClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }

    public MessageClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(callbackInstance, binding, remoteAddress)
    {
    }

    public void AddMessage(System.Guid doctorId)
    {
        base.Channel.AddMessage(doctorId);
    }

    public bool Subscribe()
    {
        return base.Channel.Subscribe();
    }

    public bool Unsubscribe()
    {
        return base.Channel.Unsubscribe();
    }
}
using Autofac;
using StudentPerformance.Forms;
using StudentPerformance.Repositories.Interfaces;
using StudentPerformance.Repositories.Stubs;

namespace StudentPerformance.Infrastructure;

public static class ContainerConfig
{
    public static IContainer Build()
    {
        ContainerBuilder builder = new();

        #region Repositories

        builder.RegisterType<DeaneryRepositoryStub>().As<IDeaneryRepository>().SingleInstance();
        builder.RegisterType<StudyStreamRepositoryStub>().As<IStudyStreamRepository>().SingleInstance();
        builder.RegisterType<StudentGroupRepositoryStub>().As<IStudentGroupRepository>().SingleInstance();
        builder.RegisterType<StudentRepositoryStub>().As<IStudentRepository>().SingleInstance();
        builder.RegisterType<DepartmentRepositoryStub>().As<IDepartmentRepository>().SingleInstance();
        builder.RegisterType<SubjectRepositoryStub>().As<ISubjectRepository>().SingleInstance();
        builder.RegisterType<TeacherRepositoryStub>().As<ITeacherRepository>().SingleInstance();
        builder.RegisterType<TeachingAssignmentRepositoryStub>().As<ITeachingAssignmentRepository>().SingleInstance();
        builder.RegisterType<GradeRepositoryStub>().As<IGradeRepository>().SingleInstance();

        #endregion

        #region Forms

        builder.RegisterType<MainForm>();
        builder.RegisterType<DepartmentListForm>().ExternallyOwned();
        builder.RegisterType<SubjectListForm>().ExternallyOwned();
        builder.RegisterType<TeacherListForm>().ExternallyOwned();
        builder.RegisterType<TeachingAssignmentListForm>().ExternallyOwned();
        builder.RegisterType<GradeListForm>().ExternallyOwned();

        #endregion

        return builder.Build();
    }
}

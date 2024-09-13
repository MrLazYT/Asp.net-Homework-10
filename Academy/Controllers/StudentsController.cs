using Academy.Data;
using Academy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Controllers
{
    public class StudentsController : Controller
    {
        public readonly AcademyContext _context;
        public readonly StudentViewModel _studentViewModel;

        public StudentsController(AcademyContext context)
        {
            _context = context;
            _studentViewModel = new StudentViewModel();
            
            List<Group> groups = _context.GetGroupList();

            _studentViewModel.Groups = groups;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = _context.GetStudentList();
            
            return View(students);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(_studentViewModel);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            return ValidateAndExecuteAction(_context.AddStudent, student);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student = _context.GetStudentById(id);
            _studentViewModel.Student = student;

            return View(_studentViewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, Student student)
        {
            return ValidateAndExecuteAction(_context.UpdateStudent, student);
        }

        public IActionResult Delete(int id)
        {
            Student student = _context.GetStudentById(id);

            return ValidateAndExecuteAction(_context.RemoveStudent, student);
        }

        public IActionResult ValidateAndExecuteAction(Action<Student> action, Student student)
        {
            if (student == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                return ExecuteAction(action, student);
            }

            _studentViewModel.Student = student;

            return View(_studentViewModel);
        }

        public IActionResult ExecuteAction(Action<Student> action, Student student)
        {
            action.Invoke(student);

            return RedirectToAction("Index");
        }
    }
}
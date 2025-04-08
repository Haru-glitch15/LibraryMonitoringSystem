using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class mainMenu: Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            newStudent studentFrm = new newStudent();
            Point buttonScreenPos = btnAddStud.PointToScreen(Point.Empty);
            studentFrm.StartPosition = FormStartPosition.Manual;
            studentFrm.Location = new Point(buttonScreenPos.X, buttonScreenPos.Y + btnAddStud.Height);
            studentFrm.Show();

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            newBook bookFrm = new newBook();
            Point buttonScreenPos = btnAddStud.PointToScreen(Point.Empty);
            bookFrm.StartPosition = FormStartPosition.Manual;
            bookFrm.Location = new Point(buttonScreenPos.X, buttonScreenPos.Y + btnAddStud.Height);
            bookFrm.Show();
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            issueBook issueFrm = new issueBook();
            Point buttonScreenPos = btnIssueBook.PointToScreen(Point.Empty);
            issueFrm.StartPosition = FormStartPosition.Manual;
            issueFrm.Location = new Point(buttonScreenPos.X, buttonScreenPos.Y + btnIssueBook.Height);
            issueFrm.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            returnBook returnFrm = new returnBook();
            Point buttonScreenPos = btnIssueBook.PointToScreen(Point.Empty);
            returnFrm.StartPosition = FormStartPosition.Manual;
            returnFrm.Location = new Point(buttonScreenPos.X, buttonScreenPos.Y + btnIssueBook.Height);
            returnFrm.Show();
        }
    }
}

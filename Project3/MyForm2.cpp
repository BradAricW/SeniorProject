#include "MyForm2.h"
using namespace System;
using namespace System::Windows::Forms;
[STAThread]

void main()
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Project3::MyForm2 form;
	Application::Run(%form);
}
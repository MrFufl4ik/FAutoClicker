//Usings
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using WindowsInput.Native;
namespace FAutoClicker
{
    public partial class MainWindow : Form
    {
        //Настройки билда
        string Language = "ENG"; //RUS = Русский Язык (Russian Launguage) //Eng Английский Язык (English Launguage)
        //Система локализации
        string btn_StartM1 = "Запустить";
        string btn_StartM2 = "Остановить";
        string btn_BindM1 = "Нету";
        string label3M1 = "Зажимать:";
        string label3M2 = "Кликать:";
        Point defaultPanel1Point = new Point(69,41);
        Point newPanel1Point = new Point(79, 41);
        void LauguageCheck()
        {
            if (Language == "RUS")
            {
                //Русский по умолчанию / Russian default
            }
            else if (Language == "ENG")
            {
                //Текст
                label6.Text = "Product: FAutoClicker | Version: 1.1.0";
                btn_Start.Text = "Run";
                btn_StartM1 = "Run";
                btn_StartM2 = "Stop";
                label4.Text = "Bind:";
                btn_BindM1 = "None";
                label1.Text = "Click delay:";
                label2.Text = "Milliseconds";
                label3M2 = "Click:";
                label3M1 = "Clump:";
                label5.Text = "Click style:";
                rb_Singl.Text = "Single";
                rb_Double.Text = "Double";
                rb_Left.Text = "Left Button";
                rb_Right.Text = "Right Button";
                label7.Text = "Clicker Type:";
                rb_DefaultMode.Text = "Normal";
                rb_DownMode.Text = "Clumping";
                //Место нахождение
                label6.Location = new Point(132, 169);
                rb_Singl.Location = new Point(76, 68);
                rb_Double.Location = new Point(138, 68);
                textBox1.Location = new Point(85, 16);
                label2.Location = new Point(189, 17);
                rb_DownMode.Location = new Point(76, 1);
                panel2.Location = new Point(86, 91);
                defaultPanel1Point = new Point(40, 41);
                newPanel1Point = new Point(50, 41);
                rb_Right.Location = new Point(94, 1);
            }
            else
            {
                //Если язык был установлен неверно
                MessageBox.Show("Язык при билде был установлен неверно! / The build language was set incorrectly!", "Ошибка билда/ Build Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Русский будет по умлочанию/ Russian will be the default","Информация/ Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //Перменные для работы программы
        static bool bindSet = false; //Састояние установки бинда
        static string bind = ""; //Текущей бинд для включение / отключения кликера
        static bool clickerState = false; // Текущее састояние кликера
        static bool LeftClick = true;
        static bool RightClick = false;
        //Обычный авто-кликер
        int clickerCD = 500; // КД кликера при произведение клика
        //Режим зажатие
        static bool UpAndDownMode = false;
        static bool downAndUpState = false;

        //Приобразование VKCODE в клавишу клавиатуры
        public static string VkCodeToName(int vkCode)
        {
            VirtualKeyCode keyCode = (VirtualKeyCode)vkCode;

            switch (keyCode)
            {
                // Основные клавиши
                case VirtualKeyCode.ESCAPE:
                    return "Escape";
                case VirtualKeyCode.F1:
                    return "F1";
                case VirtualKeyCode.F2:
                    return "F2";
                case VirtualKeyCode.F3:
                    return "F3";
                case VirtualKeyCode.F4:
                    return "F4";
                case VirtualKeyCode.F5:
                    return "F5";
                case VirtualKeyCode.F6:
                    return "F6";
                case VirtualKeyCode.F7:
                    return "F7";
                case VirtualKeyCode.F8:
                    return "F8";
                case VirtualKeyCode.F9:
                    return "F9";
                case VirtualKeyCode.F10:
                    return "F10";
                case VirtualKeyCode.F11:
                    return "F11";
                case VirtualKeyCode.F12:
                    return "F12";
                case VirtualKeyCode.PRINT:
                    return "PrintScreen";
                case VirtualKeyCode.SCROLL:
                    return "ScrollLock";
                case VirtualKeyCode.PAUSE:
                    return "Pause";
                case VirtualKeyCode.OEM_3:
                    return "`";
                case VirtualKeyCode.VK_1:
                    return "1";
                case VirtualKeyCode.VK_2:
                    return "2";
                case VirtualKeyCode.VK_3:
                    return "3";
                case VirtualKeyCode.VK_4:
                    return "4";
                case VirtualKeyCode.VK_5:
                    return "5";
                case VirtualKeyCode.VK_6:
                    return "6";
                case VirtualKeyCode.VK_7:
                    return "7";
                case VirtualKeyCode.VK_8:
                    return "8";
                case VirtualKeyCode.VK_9:
                    return "9";
                case VirtualKeyCode.VK_0:
                    return "0";
                case VirtualKeyCode.OEM_MINUS:
                    return "-";
                case VirtualKeyCode.OEM_PLUS:
                    return "+";
                case VirtualKeyCode.BACK:
                    return "Backspace";
                case VirtualKeyCode.TAB:
                    return "Tab";
                case VirtualKeyCode.VK_Q:
                    return "Q";
                case VirtualKeyCode.VK_W:
                    return "W";
                case VirtualKeyCode.VK_E:
                    return "E";
                case VirtualKeyCode.VK_R:
                    return "R";
                case VirtualKeyCode.VK_T:
                    return "T";
                case VirtualKeyCode.VK_Y:
                    return "Y";
                case VirtualKeyCode.VK_U:
                    return "U";
                case VirtualKeyCode.VK_I:
                    return "I";
                case VirtualKeyCode.VK_O:
                    return "O";
                case VirtualKeyCode.VK_P:
                    return "P";
                case VirtualKeyCode.OEM_4:
                    return "[";
                case VirtualKeyCode.OEM_6:
                    return "]";
                case VirtualKeyCode.OEM_5:
                    return "\\";
                case VirtualKeyCode.CAPITAL:
                    return "CapsLock";
                case VirtualKeyCode.VK_A:
                    return "A";
                case VirtualKeyCode.VK_S:
                    return "S";
                case VirtualKeyCode.VK_D:
                    return "D";
                case VirtualKeyCode.VK_F:
                    return "F";
                case VirtualKeyCode.VK_G:
                    return "G";
                case VirtualKeyCode.VK_H:
                    return "H";
                case VirtualKeyCode.VK_J:
                    return "J";
                case VirtualKeyCode.VK_K:
                    return "K";
                case VirtualKeyCode.VK_L:
                    return "L";
                case VirtualKeyCode.OEM_1:
                    return ";";
                case VirtualKeyCode.OEM_7:
                    return "'";
                case VirtualKeyCode.RETURN:
                    return "Enter";
                case VirtualKeyCode.LSHIFT:
                    return "LShift";
                case VirtualKeyCode.RSHIFT:
                    return "RShift";
                case VirtualKeyCode.VK_Z:
                    return "Z";
                case VirtualKeyCode.VK_X:
                    return "X";
                case VirtualKeyCode.VK_C:
                    return "C";
                case VirtualKeyCode.VK_V:
                    return "V";
                case VirtualKeyCode.VK_B:
                    return "B";
                case VirtualKeyCode.VK_N:
                    return "N";
                case VirtualKeyCode.VK_M:
                    return "M";
                case VirtualKeyCode.OEM_COMMA:
                    return ",";
                case VirtualKeyCode.OEM_PERIOD:
                    return ".";
                case VirtualKeyCode.OEM_2:
                    return "/";
                case VirtualKeyCode.LCONTROL:
                    return "LCtrl";
                case VirtualKeyCode.RCONTROL:
                    return "RCtrl";
                case VirtualKeyCode.LMENU:
                    return "LAlt";
                case VirtualKeyCode.RMENU:
                    return "RAlt";
                case VirtualKeyCode.SPACE:
                    return "Space";
                case VirtualKeyCode.INSERT:
                    return "Insert";
                case VirtualKeyCode.DELETE:
                    return "Delete";
                case VirtualKeyCode.HOME:
                    return "Home";
                case VirtualKeyCode.END:
                    return "End";
                case VirtualKeyCode.UP:
                    return "Up";
                case VirtualKeyCode.DOWN:
                    return "Down";
                case VirtualKeyCode.LEFT:
                    return "Left";
                case VirtualKeyCode.RIGHT:
                    return "Right";
                case VirtualKeyCode.NUMLOCK:
                    return "NumLock";
                case VirtualKeyCode.NUMPAD0:
                    return "NumPad0";
                case VirtualKeyCode.NUMPAD1:
                    return "NumPad1";
                case VirtualKeyCode.NUMPAD2:
                    return "NumPad2";
                case VirtualKeyCode.NUMPAD3:
                    return "NumPad3";
                case VirtualKeyCode.NUMPAD4:
                    return "NumPad4";
                case VirtualKeyCode.NUMPAD5:
                    return "NumPad5";
                case VirtualKeyCode.NUMPAD6:
                    return "NumPad6";
                case VirtualKeyCode.NUMPAD7:
                    return "NumPad7";
                case VirtualKeyCode.NUMPAD8:
                    return "NumPad8";
                case VirtualKeyCode.NUMPAD9:
                    return "NumPad9";
                case VirtualKeyCode.DIVIDE:
                    return "NumPadDivide";
                case VirtualKeyCode.MULTIPLY:
                    return "NumPadMultiply";
                case VirtualKeyCode.SUBTRACT:
                    return "NumPadMinus";
                case VirtualKeyCode.ADD:
                    return "NumPadPlus";
                case VirtualKeyCode.DECIMAL:
                    return "NumPadDecimal";
                // Добавьте обработку других клавиш
                default:
                    return ((Keys)vkCode).ToString();
            }
        }
        //Система хуков клавиатуры
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int
            WM_KEYDOWN = 0x100,    
            WM_KEYUP = 0x101;       

        private LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN || code >= 0 && wParam == (IntPtr)260)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                AutoClickerBind(vkCode.ToString());
            }
            return IntPtr.Zero;
        }
        //Система хуков мыши

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        //Функции для обычного авто-кликера
        public void LeftClickSingle()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        public void RightClickSingle()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
            Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }
        public void LeftClickDouble()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        public void RightClickDouble()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
            Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
            Thread.Sleep(5);
            mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }
        //Функции для режима зажатия
        static public void LeftDown()
        {

            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
        }
        static public void RightDown()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTDOWN, X, Y, 0, 0);
        }
        static public void LeftUP()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        static public void RightUP()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_RIGHTUP, X, Y, 0, 0);
        }
        public MainWindow()
        {
            InitializeComponent();
            IntPtr hInstance = LoadLibrary("User32"); //Запуск хука
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0); //Запуск хука
        }

        //Основные функции программы

        private void MainWindow_Load(object sender, EventArgs e) //При запуски формы
        {
            Thread t1 = new Thread(AutoClicker); //Создание потока с функцией AutoClicker
            t1.Start(); //Запуск потока
            Thread t2 = new Thread(AutoClickerUpdate); //Создание потока с функцией AutoClickerUpdate
            t2.Start(); //Запуск потока
            LauguageCheck();
        }

        void AutoClicker() //Основная функция автоклика
        {
            while (true) //Бесконечный цикл
            {
                if (clickerState) //Если кликер включен то
                {
                    if (rb_DownMode.Checked)
                    {
                        Thread.Sleep(150);
                        continue;
                    }
                    Thread.Sleep(clickerCD); //Задержка клика
                    if (rb_Singl.Checked) //Если включен пункт одиночного нажатия
                    {
                        if (rb_Left.Checked) //Если включено нажатие левой кнопкой мыши
                            LeftClickSingle(); //Эмулирование одиночного клика левой кнопкой мыши
                        else //Если включено нажатие правой кнопкой мыши
                            RightClickSingle(); //Эмулирование одиночного клика правой кнопкой мыши
                    }
                    else //Если включен пункт двойного нажатия
                    {
                        if (rb_Left.Checked) //Если включено нажатие левой кнопкой мыши
                            LeftClickDouble(); //Эмулирование двойного клика левой кнопкой мыши
                        else //Если включено нажатие правой кнопкой мыши
                            RightClickDouble(); //Эмулирование двойного клика правой кнопкой мыши
                    }

                }
                else //Если кликер выключен
                {
                    Thread.Sleep(150); //Задерждка чтобы нагрузка проца не билось под 100%
                }
            }

        }

        void AutoClickerUpdate() //Функция обновление текста
        {
            while (true) //Бесконечный цикл
            {
                if (rb_DownMode.Checked)
                {
                    label3.Text = label3M1;
                    panel1.Location = newPanel1Point;
                }
                else
                {
                    label3.Text = label3M2;
                    panel1.Location = defaultPanel1Point;
                }
                if (clickerState) //Если кликер ON
                {
                    btn_Start.Text = btn_StartM2; //Меняем текст кнопки 
                    ColorePanel.BackColor = Color.LimeGreen; //Меняем цвет в верху
                    label7.Enabled = false;
                    rb_DefaultMode.Enabled = false;
                    rb_DownMode.Enabled = false;
                }
                else //Если кликер OFF
                {
                    btn_Start.Text = btn_StartM1; //Меняем текст кнопки 
                    ColorePanel.BackColor = Color.Brown; //Меняем цвет в верху
                    label7.Enabled = true;
                    rb_DefaultMode.Enabled = true;
                    rb_DownMode.Enabled = true;
                }
                if (bindSet) //Если идет установка бинда
                {
                    btn_BindSet.Text = "..."; //Меняем текст кнопки 
                    btn_BindSet.Enabled = false; //Выключаем кнопку
                    btn_Start.Enabled = false; //Выключаем кнопку старта
                }
                else //Если не идет установка бинда
                {
                    if (bind != "") //Если бинд не пустой то
                        btn_BindSet.Text = VkCodeToName(Convert.ToInt32(bind)); //Устанавливаем кнопку бинда в текст
                    else // Если бинд пустой
                        btn_BindSet.Text = btn_BindM1; //Устанавливаем текст кнопки
                    btn_BindSet.Enabled = true; //Включаем кнопку
                    btn_Start.Enabled = true; //Включаем кнопку старта
                }
                Thread.Sleep(100); //Задержка для того чтобы проц не долбился в 100%
            }

        }
        static void AutoClickerBind(string key) //Функция для проверки кнопки на установку бинда и работу бинда
        {
            if (bindSet) //Если идет установка бинда
            {
                bindSet = false; //Меняем састояним установки бинда
                bind = key; //Устанавливаем значение бинда на клавишу пользователя
                if (key == "27") //Если клавиша ESC
                {
                    bind = ""; //Убираем бинд
                }
            }
            else //Если бинд не устанавливаеться
            {
                if (key == bind) //Сравниваем клавишу пользователя и бинд
                {
                    if (clickerState)
                    {
                        AutoDownAndUpUpdate();
                        clickerState = false; //Выключаем
                    }

                    else
                    {
                        clickerState = true; //Включаем
                        AutoDownAndUpUpdate();

                    }
                }
            }
        }
        private void btn_Start_Click(object sender, EventArgs e) //Кнопка запуска кликера
        {
            if (clickerCD != null && clickerCD > 0) //Если КД не NULL и больше 0
            {
                if (clickerState) //Если кликер включен 
                {
                    AutoDownAndUpUpdate();
                    clickerState = false; //Выключение кликера
                }
                else //Если кликер выключен
                {
                    AutoDownAndUpUpdate();
                    clickerState = true; //Включение кликера
                }
            }
        }

        static void AutoDownAndUpUpdate()
        {
            if (clickerState)
            {
                if (UpAndDownMode)
                {
                    if (downAndUpState)
                    {
                        if (LeftClick)
                        {
                            LeftUP();
                        }
                        else
                        {
                            RightUP();
                        }
                        downAndUpState = false;
                    }
                    else
                    {
                        if (LeftClick)
                        {
                            LeftDown();
                        }
                        else
                        {
                            RightDown();
                        }
                        downAndUpState = true;
                    }
                }
            }
        }

        

        private void tbx_CdInput_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (textBox1.Text == "" && e.KeyChar == '\b') //Если бокс пуст и значение которое ввел пользователь это BackSpace
                return;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b') //Отсеивание всего кроме BackSpase || Цифр
            {
                e.Handled = true;
            }
            else //Если это цифры || BackSpace
            {
                if (e.KeyChar != '\b') //Если это не BackSpace
                {
                    if (textBox1.Text + e.KeyChar != "") // Прибавление текушего значения TextBox и значения которое ввел пользователь чтобы проверить их на пустоту
                    {
                        if (e.KeyChar != '\b') //Если символ не BackSpace
                        {
                            clickerCD = Convert.ToInt32(textBox1.Text + e.KeyChar); //Установливаем КД прибавив новый символ
                        }
                        else
                        {
                            clickerCD = Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 1)); //Установливаем КД удалив один символ
                        }
                    }
                    else //Если при прибовление символа строка будет пустой
                    {
                        clickerCD = 0; //Обнуляем кд в ноль
                    }
                }
                else //Если это Backspace
                {
                    if (textBox1.Text.Substring(0, textBox1.Text.Length - 1) != "") //Если при убирание символа строка не пустая
                    {
                        clickerCD = Convert.ToInt32(textBox1.Text.Substring(0, textBox1.Text.Length - 1)); //Удаляем последний символ и устанавливем КД
                    }
                    else
                    { //Если при прибовлении строки будет пустота
                        clickerCD = 0; //Обнуляем кд
                    }
                }
            }
        }



        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e) //Действия при закрытие формы
        {
            UnhookWindowsHookEx(hhook); //Отключение хуков клавиатуры
            Environment.Exit(0); //Полный выход со отключением всех потоков
        }

        private void MyTGLink_Clicked(object sender, LinkLabelLinkClickedEventArgs e) //Клик по ссылки на мой телеграмм канал
        {
            Process.Start("https://t.me/FSoftwareProject"); //Переход на мой телеграмм канал
        }

        private void rb_UpMode_Click(object sender, EventArgs e)
        {
            if (!clickerState)
            {
                if (rb_DefaultMode.Checked)
                {
                    textBox1.Enabled = true;
                    rb_Singl.Enabled = true;
                    rb_Double.Enabled = true;
                    label1.Enabled = true;
                    label2.Enabled = true;
                    label5.Enabled = true;
                    UpAndDownMode = false;
                }
                else
                {
                    textBox1.Enabled = false;
                    rb_Singl.Enabled = false;
                    rb_Double.Enabled = false;
                    label1.Enabled = false;
                    label2.Enabled = false;
                    label5.Enabled = false;
                    UpAndDownMode = true;
                }
            }
            else
            {
                rb_DefaultMode.Checked = true;
            }
        }

        private void rb_Left_Click(object sender, EventArgs e)
        {
            if (rb_Left.Checked)
            {
                LeftClick = true;
                RightClick = false;
            }
            else{
                RightClick = true;
                LeftClick = false;
            }
        }

        private void btn_BindSet_Clicked(object sender, EventArgs e) //Клик по кнопки установки бинда
        {
            if (!bindSet) //Если бинд не устанавливаеться
            {
                bindSet = true; //Переключаем состояние установки бинда
            }
        }
    }
}

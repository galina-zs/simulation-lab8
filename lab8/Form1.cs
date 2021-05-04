using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        double U = 1;
        const int p = 5087; // большое простое число
        int M = 2900;       // M = p - 3^n. Берем n = 7, потому что 3^8 > p
        double R;

        public Form1()
        {
            InitializeComponent();
        }

        private void yesOrNoButton_Click(object sender, EventArgs e)
        {
            Generator();
            if (R < 0.5)
                yesOrNoAnswerLabel.Text = "НЕТ";
            else
                yesOrNoAnswerLabel.Text = "ДА";
        }

        private void predictionButton_Click(object sender, EventArgs e) // не придумала, как короче сделать
        {
            Generator();
            if (R < 0.05)
                predictionAnswerLabel.Text = "Бесспорно";
            else if (R < 0.1)
                predictionAnswerLabel.Text = "Предрешено";
            else if (R<0.15)
                predictionAnswerLabel.Text = "Никаких сомнений";
            else if (R<0.2)
                predictionAnswerLabel.Text = "Определённо да";
            else if (R<0.25)
                predictionAnswerLabel.Text = "Можешь быть уверен/а в этом";
            else if (R<0.3)
                predictionAnswerLabel.Text = "Мне кажется — «да»";
            else if (R<0.35)
                predictionAnswerLabel.Text = "Вероятнее всего";
            else if (R<0.4)
                predictionAnswerLabel.Text = "Хорошие перспективы";
            else if (R<0.45)
                predictionAnswerLabel.Text = "Знаки говорят — «да»";
            else if (R<0.5)
                predictionAnswerLabel.Text = "Да";
            else if (R<0.55)
                predictionAnswerLabel.Text = "Пока не ясно, попробуй снова";
            else if (R<0.6)
                predictionAnswerLabel.Text = "Спроси позже";
            else if (R<0.65)
                predictionAnswerLabel.Text = "Лучше не рассказывать";
            else if (R<0.7)
                predictionAnswerLabel.Text = "Сейчас нельзя предсказать";
            else if (R<0.75)
                predictionAnswerLabel.Text = "Сконцентрируйся и спроси опять";
            else if (R<0.8)
                predictionAnswerLabel.Text = "Даже не думай";
            else if (R<0.85)
                predictionAnswerLabel.Text = "Мой ответ — «нет»";
            else if (R<0.9)
                predictionAnswerLabel.Text = "По моим данным — «нет»";
            else if (R<0.95)
                predictionAnswerLabel.Text = "Перспективы не очень хорошие";
            else if (R<1)
                predictionAnswerLabel.Text = "Весьма сомнительно";
        }

        private void Generator() // метод вычетов. Модификация Коробова
        {
            R = U / p;
            U = (U * M) % p;
        }
    }
}

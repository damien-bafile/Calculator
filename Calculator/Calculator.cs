//Author Name: Damien Bafile
//Creation Date: 13/06/2019
//Version Control: https://github.com/damien-bafile
//

using System;
using System.Globalization;
using System.Windows.Forms;
using AlgebraicMath;
using ArithmeticMath;
using Calculator.Properties;
using TrigonometricMath;

namespace Calculator
{
    /// <summary>
    ///     Main form of application
    /// </summary>
    public partial class FrmCalculator : Form
    {
        //Add comments here that explain these 4 Operator methods
        //Explain each of the Variables
        private double _amountA; //Change these names to improve clarity
        private double? _amountB; //Try using the built-in REFACTOR
        private bool _divideButtonClicked;
        private bool _minusButtonClicked;
        private bool _multiplyButtonClicked;
        private bool _negativeButtonClicked;
        private bool _plusButtonClicked;

        /// <summary>
        ///     Constructor class
        /// </summary>
        public FrmCalculator()
        {
            InitializeComponent();
        }


        /// <summary>
        ///     Preforms flagged Arithmetic operations on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // Check which flags have been checked
            if (_plusButtonClicked)
                _amountB = Arithmetic.Addition(_amountA, double.Parse(txtDisplay.Text));
            else if (_minusButtonClicked)
                _amountB = Arithmetic.Subtraction(_amountA, double.Parse(txtDisplay.Text));
            else if (_divideButtonClicked)
                _amountB = Arithmetic.Divide(_amountA, double.Parse(txtDisplay.Text));
            else if (_multiplyButtonClicked) _amountB = Arithmetic.Multiply(_amountA, double.Parse(txtDisplay.Text));

            txtDisplay.Text = _amountB == null ? Resources.cannotDivBy0 : _amountB.ToString();

            _amountA = 0;
        }

        #region Number Buttons

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            _negativeButtonClicked = false;
        }

        #endregion

        #region Arithmetic

        /// <summary>
        ///     Sets the _plusButtonClicked to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            _amountA += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            _plusButtonClicked = true;
            _minusButtonClicked = false;
            _divideButtonClicked = false;
            _multiplyButtonClicked = false;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_negativeButtonClicked == false && !string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                _negativeButtonClicked = true;
                _amountA += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = true;
                _divideButtonClicked = false;
                _multiplyButtonClicked = false;
            }
            else if (_negativeButtonClicked == false && string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                _negativeButtonClicked = true;
                txtDisplay.Text = Resources.negativeSymbol;
            }
            else if (_negativeButtonClicked && txtDisplay.Text.Substring(0, 1) == "-")
            {
                _negativeButtonClicked = false;
                _amountA += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = true;
                _divideButtonClicked = false;
                _multiplyButtonClicked = false;
            }
            else
            {
                _plusButtonClicked = false;
                _minusButtonClicked = true;
                _divideButtonClicked = false;
                _multiplyButtonClicked = false;
            }
        }

        /// <summary>
        ///     Sets the _multiplyButtonClicked to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            _amountA += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            _plusButtonClicked = false;
            _minusButtonClicked = false;
            _divideButtonClicked = false;
            _multiplyButtonClicked = true;
        }

        /// <summary>
        ///     Sets the _divideButtonClicked to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            _amountA += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            _plusButtonClicked = false;
            _minusButtonClicked = false;
            _divideButtonClicked = true;
            _multiplyButtonClicked = false;
        }

        #endregion

        #region Trigonometric

        /// <summary>
        ///     Performs Tangent Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTangent_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Trigonometric.Tangent(double.Parse(txtDisplay.Text));
                if (double.IsNaN(result.Value))
                {
                    txtDisplay.Text = Resources.invalidText;
                    _amountA = 0;
                }
                else
                {
                    txtDisplay.Text = result.ToString();
                    _amountA = 0;
                }
            }
            catch (Exception)
            {
                txtDisplay.Text = Resources.invalidText;
                _amountA = 0;
            }
        }

        /// <summary>
        ///     Performs Sine Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSine_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Trigonometric.Sine(double.Parse(txtDisplay.Text));
                txtDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
                _amountA = 0;
            }
            catch (Exception)
            {
                txtDisplay.Text = Resources.invalidText;
            }
        }

        /// <summary>
        ///     Performs Cosine Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCosine_Click(object sender, EventArgs e)
        {
            try
            {
                var result = Trigonometric.Cosine(double.Parse(txtDisplay.Text));
                txtDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
                _amountA = 0;
            }
            catch (Exception)
            {
                txtDisplay.Text = Resources.invalidText;
            }
        }

        #endregion

        #region Algebraic

        /// <summary>
        ///     Performs Square Root Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.SquareRoot(double.Parse(txtDisplay.Text)) != null
                ? Algebraic.SquareRoot(double.Parse(txtDisplay.Text)).ToString()
                : "Number Not Possible";
            _amountA = 0;
        }

        /// <summary>
        ///     Performs Cube Root Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.CubeRoot(double.Parse(txtDisplay.Text)).ToString(CultureInfo.InvariantCulture);
            _amountA = 0;
        }

        /// <summary>
        ///     Performs Inverse Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (Algebraic.Inverse(double.Parse(txtDisplay.Text)) != null)
                txtDisplay.Text = Algebraic.Inverse(double.Parse(txtDisplay.Text)).ToString();
            else
                txtDisplay.Text = Resources.cannotDivBy0;

            _amountA = 0;
        }

        #endregion

        #region Keyboard Controls

        /// <summary>
        ///     Determines the keyboard entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '1') btnOne.PerformClick();

            if (e.KeyChar == '2') btnTwo.PerformClick();

            if (e.KeyChar == '3') btnThree.PerformClick();

            if (e.KeyChar == '4') btnFour.PerformClick();

            if (e.KeyChar == '5') btnFive.PerformClick();

            if (e.KeyChar == '6') btnSix.PerformClick();

            if (e.KeyChar == '7') btnSeven.PerformClick();

            if (e.KeyChar == '8') btnEight.PerformClick();

            if (e.KeyChar == '9') btnNine.PerformClick();

            if (e.KeyChar == '0') btnZero.PerformClick();

            if (e.KeyChar == '+') btnPlus.PerformClick();

            if (e.KeyChar == '-') btnMinus.PerformClick();

            if (e.KeyChar == '*') btnMultiply.PerformClick();

            if (e.KeyChar == '/') btnDivide.PerformClick();

            if (e.KeyChar == 'c' || e.KeyChar == 'C') btnCosine.PerformClick();

            if (e.KeyChar == 's' || e.KeyChar == 'S') btnSine.PerformClick();

            if (e.KeyChar == 't' || e.KeyChar == 'T') btnTangent.PerformClick();

            if (e.KeyChar == 'q' || e.KeyChar == 'Q') btnSquareRoot.PerformClick();

            if (e.KeyChar == 'r' || e.KeyChar == 'R') btnCubeRoot.PerformClick();

            if (e.KeyChar == 'i' || e.KeyChar == 'I') btnInverse.PerformClick();
        }

        /// <summary>
        ///     Sets up copy and paste shortcuts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnClear.PerformClick();

            if (e.Control && e.KeyCode == Keys.C)
            {
                txtDisplay.SelectAll();
                txtDisplay.Copy();
                txtDisplay.DeselectAll();
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                var str = Clipboard.GetText();
                if (IsDecimalFormat(str)) txtDisplay.AppendText(str);
            }
        }

        /// <summary>
        ///     Determines if a string is a decimal format
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static bool IsDecimalFormat(string str)
        {
            return decimal.TryParse(str, out var dummy);
        }

        #endregion
    }
}
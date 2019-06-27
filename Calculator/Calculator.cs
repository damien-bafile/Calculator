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
        private bool _clear; // For checking if the txtDisplay needs clearing
        private bool _divideButtonClicked;
        private bool _minusButtonClicked;
        private bool _multiplyButtonClicked;
        private bool _negativeButtonClicked;
        private bool _plusButtonClicked;

        private double _tempValue; // Temporary variable for Arithmetic operations
        private double? _totalAmount;

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
            if (_plusButtonClicked)
                _totalAmount = Arithmetic.Addition(_tempValue, double.Parse(txtDisplay.Text));
            else if (_minusButtonClicked)
                _totalAmount = Arithmetic.Subtraction(_tempValue, double.Parse(txtDisplay.Text));
            else if (_divideButtonClicked)
                _totalAmount = Arithmetic.Divide(_tempValue, double.Parse(txtDisplay.Text));
            else if (_multiplyButtonClicked)
                _totalAmount = Arithmetic.Multiply(_tempValue, double.Parse(txtDisplay.Text));
            

            txtDisplay.Text = _totalAmount == null ? Resources.cannotDivBy0 : _totalAmount.ToString();
            if (_totalAmount == null)
            {
                txtDisplay.Text = Resources.cannotDivBy0;
            }
            else
            {
                txtDisplay.Text = _totalAmount.ToString();
                _negativeButtonClicked = _totalAmount < 0 ? true : false;
            }

            _clear = true;
            _tempValue = 0;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }

        #region Number Buttons

        /// <summary>
        ///     Prints 1 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                txtDisplay.Text = btnOne.Text;
                _clear = false;
            }
            else
            {
                txtDisplay.Text += btnOne.Text;
            }

            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 2 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (_clear)
            {
                txtDisplay.Text = btnTwo.Text;
                _clear = false;
            }
            else
            {
                txtDisplay.Text += btnTwo.Text;
            }

            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 3 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnThree.Text;
            else
                txtDisplay.Text += btnThree.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 4 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFour_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnFour.Text;
            else
                txtDisplay.Text += btnFour.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 5 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFive_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnFive.Text;
            else
                txtDisplay.Text += btnFive.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 6 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSix_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnSix.Text;
            else
                txtDisplay.Text += btnSix.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 7 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnSeven.Text;
            else
                txtDisplay.Text += btnSeven.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 8 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEight_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnEight.Text;
            else
                txtDisplay.Text += btnEight.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 9 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNine_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnNine.Text;
            else
                txtDisplay.Text += btnNine.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints 0 to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (_clear)
                txtDisplay.Text = btnZero.Text;
            else
                txtDisplay.Text += btnZero.Text;
            btnEquals.Select();
        }

        /// <summary>
        ///     Prints . to txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += txtDisplay.Text.Contains(".") ? "" : ".";
            btnEquals.Select();
        }

        /// <summary>
        ///     Clears txtDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            _clear = false;
            _totalAmount = 0;
            _totalAmount = 0;
            _plusButtonClicked = false;
            _minusButtonClicked = false;
            _divideButtonClicked = false;
            _multiplyButtonClicked = false;
            _negativeButtonClicked = false;
            btnEquals.Select();
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
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                _tempValue += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();
                _plusButtonClicked = true;
                _minusButtonClicked = false;
                _divideButtonClicked = false;
                _multiplyButtonClicked = false;
                btnEquals.Select();
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (_negativeButtonClicked == false && !string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                _tempValue += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = true;
                _divideButtonClicked = false;
                _multiplyButtonClicked = false;
            }
            else if (_negativeButtonClicked == false && string.IsNullOrWhiteSpace(txtDisplay.Text))
            {
                txtDisplay.Text = Resources.negativeSymbol;
                _negativeButtonClicked = true;
            }

            btnEquals.Select();
        }

        /// <summary>
        ///     Sets the _multiplyButtonClicked to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                _tempValue += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = false;
                _divideButtonClicked = false;
                _multiplyButtonClicked = true;
            }

            btnEquals.Select();
        }

        /// <summary>
        ///     Sets the _divideButtonClicked to true
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            double temp;
            if (!string.IsNullOrEmpty(txtDisplay.Text))
            {
                _tempValue += double.Parse(txtDisplay.Text);
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = false;
                _divideButtonClicked = true;
                _multiplyButtonClicked = false;
            }

            btnEquals.Select();
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
                if (double.IsNaN(result.Value) == null)
                {
                    txtDisplay.Text = Resources.invalidText;
                    _tempValue = 0;
                }
                else
                {
                    txtDisplay.Text = result.ToString();
                    _tempValue = 0;
                }
            }
            catch (Exception)
            {
                txtDisplay.Text = Resources.invalidText;
                _tempValue = 0;
            }

            btnEquals.Select();
            _clear = true;
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
                _tempValue = 0;
            }
            catch (Exception)
            {
                txtDisplay.Text = Resources.invalidText;
            }

            btnEquals.Select();
            _clear = true;
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
                _tempValue = 0;
            }
            catch (Exception)
            {
                txtDisplay.Text = Resources.invalidText;
            }

            btnEquals.Select();
            _clear = true;
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
            _tempValue = 0;
            btnEquals.Select();
            _clear = true;
        }

        /// <summary>
        ///     Performs Cube Root Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.CubeRoot(double.Parse(txtDisplay.Text)).ToString();
            _tempValue = 0;
            btnEquals.Select();
            btnEquals.Select();
            btnEquals.Select();
            _clear = true;
        }

        /// <summary>
        ///     Performs Inverse Function on number in textDisplay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInverse_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = Algebraic.Inverse(double.Parse(txtDisplay.Text)) != null
                ? Algebraic.Inverse(double.Parse(txtDisplay.Text)).ToString()
                : Resources.cannotDivBy0;

            _tempValue = 0;
            btnEquals.Select();
            btnEquals.Select();
            btnEquals.Select();
            _clear = true;
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
            if (e.KeyCode == Keys.Enter) btnEquals.PerformClick();
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
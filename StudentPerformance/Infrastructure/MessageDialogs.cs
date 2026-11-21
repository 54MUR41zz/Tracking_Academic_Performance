namespace StudentPerformance.Infrastructure;

public static class MessageDialogs
{
    private const string ApplicationTitle = "Учёт успеваемости студентов";

    public static void ShowInputError(IWin32Window owner, string message)
    {
        MessageBox.Show(owner, message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void ShowRowNotSelected(IWin32Window owner)
    {
        MessageBox.Show(
            owner,
            "Выберите запись в списке.",
            ApplicationTitle,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    public static bool ConfirmDeletion(IWin32Window owner, string itemTitle)
    {
        DialogResult answer = MessageBox.Show(
            owner,
            $"Удалить запись «{itemTitle}»?",
            "Подтверждение удаления",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        return answer == DialogResult.Yes;
    }
}

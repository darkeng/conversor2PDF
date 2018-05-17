using System.Collections.Generic;
using System.IO;

namespace conversor2PDF
{
    class datos
    {
        private string[] _todos;
        private List<string> _worls;
        private List<string> _exels;
        private List<string> _powerp;
        private int _otros;
        public datos()
        {
            _worls = new List<string>();
            _exels = new List<string>();
            _powerp = new List<string>();
            _otros = 0;

        }
        public void llenarDatos(string[] dtos)
        {
            this._todos = dtos;
            for (int i = 0; i < _todos.Length; i++)
            {
                string extension = Path.GetExtension(_todos[i]).ToLower();
                if (extension == ".doc" || extension == ".docx" || extension == ".odt" || extension == ".txt" || extension == ".rtf" || extension == ".xml")
                {
                    _worls.Add(_todos[i]);
                }
                else
                    if (extension == ".xls" || extension == ".xlsx" || extension == ".csv")
                    {
                        _exels.Add(_todos[i]);
                    }
                    else
                        if (extension == ".ppt" || extension == ".pptx")
                        {
                            _powerp.Add(_todos[i]);
                        }
                        else
                        {
                            _otros += 1;
                        }
            }
        }
        public string[] todos { get { return this._todos; } }
        public List<string> worlds { get { return this._worls; } }
        public List<string> exels { get { return this._exels; } }
        public List<string> powerps { get { return this._powerp; } }
        public int otros { get { return this._otros; } }

    }
}

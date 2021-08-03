import { useEffect, useState } from 'react';
import { AgGridColumn, AgGridReact } from 'ag-grid-react';

import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-alpine.css';

import './App.css';

function App() {

  const [rowData, setData] = useState([]);

  useEffect(() => {
    fetch('https://localhost:44341/api/v1/Movie/search')
      .then(res => res.json())
      .then(result => setData(result))
      .catch((err) => {
        console.log(err);
      });;
  }, []);
   

  return (
    <div className="App">    
      <div className="ag-theme-alpine ag-style">
        <AgGridReact
          defaultColDef={{ flex: 1 }}
          rowHeight={60}
          rowData={rowData} >
          <AgGridColumn field="movieId" headerName="Movie Id" sortable={true} filter={true} cellClass="vertical-middle" />
          <AgGridColumn field="movieName" headerName="Movie Name" sortable={true} filter={true} cellClass="vertical-middle" />
          <AgGridColumn field="genre" headerName="Genre" sortable={true} filter={true} cellClass="vertical-middle" />
          <AgGridColumn field="actorName" headerName="Actor Name" sortable={true} filter={true} cellClass="vertical-middle" />
        </AgGridReact>
      </div>
    </div>
  );
}

export default App;

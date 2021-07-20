import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
} from '@material-ui/core';

import { Delete as DeleteIcon } from '@material-ui/icons';

const useStyles = makeStyles({
  table: {
    minWidth: 150,
  },
  add: {
    color: 'green',
    fontSize: 40,
    margin: '2px',
  },
  tableBody: {
    overflow: 'auto',
    minWidth: '415px',
  }
});

export default function CaracteristicasTable({ list = [], exclude }) {
  const classes = useStyles();
  
  return (
    <TableContainer component={Paper}>
      <Table className={classes.table} size="small">
        <TableHead>
          <TableRow>
            <TableCell>Característica</TableCell>
            <TableCell align="right">Descrição</TableCell>
            <TableCell align="right"></TableCell>
          </TableRow>
        </TableHead>
        <TableBody className={classes.tableBody}>
          {list.map((item) => (
            <TableRow key={item.id}>
              <TableCell component="th" scope="row">
                {item.characteristic.description}
              </TableCell>
              <TableCell align="right">{item.description.description}</TableCell>
              <TableCell align="right">
                <DeleteIcon onClick={() => exclude(item.id)} />
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

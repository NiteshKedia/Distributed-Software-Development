<?xml version="1.0"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/">
		<html>  <body>
			<h1>Hotels</h1>
			<table border="1">
				<tr bgcolor="yellow"> 
					<td><b>Name </b></td> 
					<td><b>Phone</b></td> 
					<td><b>Email</b></td> 
					<td><b>Number</b></td> 
					<td><b>Street</b></td> 
					<td><b>City</b></td> 
					<td><b>Zip</b></td> 
				</tr>
				<xsl:for-each select="Hotels/Hotel">
					<tr style="font-size: 10pt; font-family: verdana">
						<td><xsl:value-of select="Name"/></td>							
							<td><xsl:value-of select="Contact/Phone"/></td>
							<td><xsl:value-of select="Contact/Email"/></td>
					
							<td><xsl:value-of select="Address/Number"/></td>
							<td><xsl:value-of select="Address/Street"/></td>
							<td><xsl:value-of select="Address/City"/></td>
							<td><xsl:value-of select="Address/Zip"/></td>
						
					</tr>
				</xsl:for-each>
			</table>
		</body> </html>
	</xsl:template>
</xsl:stylesheet>
